using System;

    class Man
    {
        
        private double weight;  // Breadth of a box
        private double height;   // Height of a box

        // Overload + operator to add two Box objects.
        public static Man operator +(Man b, Man c)
        {
            Man man = new Man();

            man.weight = b.weight + c.weight;
            man.height = b.height + c.height;
            return man;
        }

        public double getHeight()
        {
            return height;
        }

        public double getWeight()
        {
            return weight;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }
        public void setWeight(double weight)
        {
            this.weight = weight;
        }

    }

    
