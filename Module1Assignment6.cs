using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Course
{
    // Interface for data processing

    public interface IDataProcessor

    {
        string ProcessData(string input);

    }

    // Implementation of IDataProcessor

    public class UserInputProcessor : IDataProcessor

    {

        public string ProcessData(string input)

        {

            // Example operation: Convert input to uppercase

            return input.ToUpper();

        }

    }

    // Service that depends on IDataProcessor

    public class DataProcessingService

    {

        private readonly IDataProcessor _dataProcessor;

        // Constructor injection

        public DataProcessingService(IDataProcessor dataProcessor)

        {

            _dataProcessor = dataProcessor;

        }

        public void ProcessAndDisplay(string input)

        {

            // Use the injected data processor to perform the operation

            string processedData = _dataProcessor.ProcessData(input);

            // Display the processed data to the user

            Console.WriteLine($"Processed Data: {processedData}");

        }

    }

    class Program4

    {

        static void Main()

        {

            // Setup dependency injection (using a simple example without a DI container)

            IDataProcessor userInputProcessor = new UserInputProcessor();

            DataProcessingService dataProcessingService = new DataProcessingService(userInputProcessor);

            // Accept user input

            Console.Write("Enter data for processing: ");

            string userInput = Console.ReadLine();

            // Use the data processing service to perform operations and display the result

            dataProcessingService.ProcessAndDisplay(userInput);

        }

    }

}
