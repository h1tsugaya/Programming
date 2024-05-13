using System;

namespace ProjectProgramming.Model
{
    /// <summary>
    /// Представляет кольцо.
    /// </summary>
    class Ring
    {
        /// <summary>
        /// Получает центр кольца.
        /// </summary>
        public Point2D Center { get; }

        double _internalRadius;
        double _externalRadius;

        /// <summary>
        /// Получает или задает внутренний радиус кольца.
        /// </summary>
        public double InternalRadius
        {
            get { return _internalRadius; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                if (value > _externalRadius) throw new ArgumentException("The inner radius cannot be larger than the outer radius.");
                _internalRadius = value;
            }
        }

        /// <summary>
        /// Получает или задает внешний радиус кольца.
        /// </summary>
        public double ExternalRadius
        {
            get { return _externalRadius; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                if (value < _internalRadius) throw new ArgumentException("The external radius cannot be smaller than the inner radius.");
                _externalRadius = value;
            }
        }

        /// <summary>
        /// Получает площадь кольца.
        /// </summary>
        public double Area => Math.PI * Math.Pow(_externalRadius, 2) - Math.PI * Math.Pow(_internalRadius, 2);

        /// <summary>
        /// Инициализирует новый экземпляр класса Ring с указанными внутренним и внешним радиусами.
        /// </summary>
        /// <param name="internalRadius">Внутренний радиус.</param>
        /// <param name="externalRadius">Внешний радиус.</param>
        public Ring(double internalRadius, double externalRadius)
        {
            InternalRadius = internalRadius;
            ExternalRadius = externalRadius;
            Center = new Point2D(InternalRadius / 2, ExternalRadius / 2);
        }
    }
}
