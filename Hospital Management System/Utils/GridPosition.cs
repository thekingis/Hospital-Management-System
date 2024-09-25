using System;

namespace Hospital_Management_System.Utils
{
    class GridPosition
    {
        public int x, y;
        private int position, columnCount;

        public GridPosition(int position, int columnCount)
        {
            this.position = position;
            this.columnCount = columnCount;
            setPosition();
        }

        private void setPosition()
        {
            if(position < columnCount)
            {
                x = position;
                y = 1;
            } else
            {
                int row = position + 1;
                x = position % columnCount;
                y = Convert.ToInt32(Math.Ceiling((double)row / columnCount));
            }
        }

    }
}
