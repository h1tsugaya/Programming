namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Перечисление, описывающее состояние заказа.
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// Новый заказ.
        /// </summary>
        New,

        /// <summary>
        /// Заказ обрабатывается.
        /// </summary>
        Processing,

        /// <summary>
        /// Заказ собирается на складе.
        /// </summary>
        Assembly,

        /// <summary>
        /// Заказ отправлен.
        /// </summary>
        Sent,

        /// <summary>
        /// Заказ доставлен.
        /// </summary>
        Delivered,

        /// <summary>
        /// Заказ возвращен.
        /// </summary>
        Returned,

        /// <summary>
        /// Заказ отменен со стороны магазина.
        /// </summary>
        Abandoned
    }
}
