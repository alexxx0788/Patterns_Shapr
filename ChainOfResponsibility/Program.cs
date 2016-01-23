using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChainOfResponsibility.structure;

namespace ChainOfResponsibility
{
    /// <summary>
    /// http://metanit.com/sharp/patterns/3.7.php
    /// Цепочка Обязанностей (Chain of responsibility) - поведенческий шаблон проектирования, который позволяет избежать жесткой привязки отправителя запроса к получателю, позволяя нескольким объектам обработать запрос. 
    /// Все возможные обработчики запроса образуют цепочку, а сам запрос перемещается по этой цепочке, пока один из ее объектов не обработает запрос. 
    /// Каждый объект при получении запроса выбирает, либо обработать запрос, либо передать выполнение запроса следующему по цепочке.
    /// 
    /// Для примера взят случай оплаты труда программистов работающих по фрилансу. Когда способ оплаты производиться через сторонние системы.
    /// В центре внимания существует объект Receiver который может пользоваться 3-мя системами для получения денег: банковский перевод,PayPal, денежный перевод.
    /// В конструкторе мы устанавливаем для него возможные системы платежей.
    /// Также есть абстрактный класс PaymentHandler, что определяет процесс оплаты поле типа PaymentHandler Successor и метод Handle
    /// Главная мысль что мы имеет 3 звена в цепочке и строим поряд их выполнения с помошью поля Successor. Внутри реализации мы смотрим что есть клиент не использовал данный способ оплаты он передает по цепочке далее выполнение.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver(false, true, true);
            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler moneyPaymentHnadler = new MoneyPaymentHandler();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();
            bankPaymentHandler.Successor = paypalPaymentHandler;
            paypalPaymentHandler.Successor = moneyPaymentHnadler;
            bankPaymentHandler.Handle(receiver);
            Console.Read();
        }
    }
}
