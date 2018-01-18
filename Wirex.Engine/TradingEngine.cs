using System;

namespace Wirex.Engine
{
    public class TradingEngine : ITradingEngine
    {
        public void Place(Order order)
        {

        }

        public event EventHandler<OrderArgs> OrderOpened;

        public event EventHandler<OrderArgs> OrderClosed;
    }
}