namespace Unit_4___OOPa_part_2
{
    public class Room
    {
        // OOP Solves the problem of ORGANIZING YOUR IDEAS!!!!
        // implemented with the FOUR pillars of OOP
        // 
        // Abstraction -> The idear of knowing complexity is HIDDEN, CLASSES HIDE COMPLEXITY
        // Encapsolation -> promises to expose the ONLY the complexity you NEED to expose
        //                  keeping your ideas classified together.
        //
        //
        // Inhertence
        // Polymorphism

        // Constructors is a FUNCTION that will CREATE your type and RETURN 
        // ITSELF... it's responsible for CONTRUCTING your OBJECT.
        // the NAME of the class is also it's RETURN TYPE.
        public Room(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public Room(double length)
        {
            Length = length;
        }

        public Room(double length, double width, double height)
        {
            Length = length;
            _width = width;
            _height = height;
        }

        // if YOU DO NOT define a constructor YOURSELF, c# WILL provide a DEFAULT constructor
        //... it's just a constructor that takes NO arguments.
        // IF YOU PROVIDE YOUR OWN CONSTRUCTOR, the DEFUAULT CONSTRUCTOR GETS OVERIDDEN


        // AUTO PROPERTY, they HIDE or ABSTRACT the field for you because you are ONLY
        // using that field to be publically exposed
        double Length { get; set; } // the most COMMONLY USED property, the AUTO PROPERTY


        // FIELDS are PRIVATE or PROTECTED... RARELY publically exposed variables
        private double _width;


        //  PROPERTY, publically EXPOSE PRIVATE FIELDS with 
        //  GETTERS and SETTERS
        public double Width // Getters, and Setters are OPTIONAL
        {
            // GETTER
            get
            {
                // return keyword becasue it ACTS like a LIMITED function
                return _width;
            }
            // SETTER
            set
            {
                // the value is a double becuase the PROPERTY it lives in is also a double
                _width = value; // the VALUE keyword, is the SAME type as your PROPERTY
            }
        }


        private double _height;
        public double Height
        {
            // properties allow you to CONTROL the READ and WRITE level of your private
            // field
            // this is a READ ONLY property.
            get
            {
                return _height;
            }
        }


        // READ ONLY Property that is PUBLICALLY EXPOSING DATA... no field in sight here...
        public double Perimeter => 2 * (Length + Width);


        // the PRIME CASE for using READ ONLY GETTERS is if you have a 
        // METHOD that takes NO PARAMTERS, and ONLY RETURNS DATA
        // ASSOCIATED WITH YOUR CLASS

        public double Area => Length * Width;
        public double GetArea()
        {
            return Length * Width;
        }

        public double GetVolume()
        {
            return Length * _width * _height;
        }

        // the main use case for Static is for Exention methods, and private methods
    }
}
