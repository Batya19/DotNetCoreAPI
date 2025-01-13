using System;

namespace BL.Validation
{
    public static class BabyValidation
    {
        public static void ValidateBabyName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Baby's name cannot be empty.");
            }
        }

        public static void ValidateBabyId(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("id", "BabyId cannot be less than zero.");
            }
        }
    }
}