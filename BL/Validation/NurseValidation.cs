using System;

namespace BL.Validation
{
    public static class NurseValidation
    {
        public static void ValidateNurseName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Nurse's name cannot be empty.");
            }
        }

        public static void ValidateNurseId(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("id", "NurseId cannot be less than zero.");
            }
        }
    }
}
