namespace Computers
{
    /// <summary>
    /// The interface provides common way to access the motherboard of the computer system and defines its basic commands.
    /// </summary>
    public interface IMotherboard
    {
        /// <summary>
        /// Access the RAM of the computer system and extract the integer number currently saved in it.
        /// </summary>
        /// <returns>Returns the number currently saved in the RAM.</returns>
        int LoadRamValue(); 

        /// <summary>
        /// Access the RAM of the computer and saves an integer number in it.
        /// </summary>
        /// <param name="value">An integer number to be saved in the RAM.</param>
        void SaveRamValue(int value); 

        /// <summary>
        /// Adds text information to the video card in order to be printed later by the card.
        /// </summary>
        /// <param name="data">A text information in string format to be passed to the video card for visualization.</param>
        void DrawOnVideoCard(string data);
    }
}
