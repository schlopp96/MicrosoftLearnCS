/*
$ Logging and Tracing in .NET Applications

>- Tracing is a way for you to monitor the execution of your application while it's running.
<- You can add tracing and debugging instrumentation to your .NET application when you develop it. You can use that instrumentation while you're developing the application and after you've deployed it.
*- You can use that instrumentation while you're developing the application and after you've deployed it.

^ This simple technique is surprisingly powerful. It can be used in situations where you need more than a debugger:

    ?- Issues that occur over long periods of time can be difficult to debug with a traditional debugger.
        &- Logs allow for detailed post-mortem review that spans long periods of time. In contrast, debuggers are constrained to real-time analysis.

    ?- Multi-threaded applications and distributed applications are often difficult to debug.
        &- Attaching a debugger tends to modify behaviors. Detailed logs can be analyzed as needed to understand complex systems.

    ?- Issues in distributed applications might arise from a complex interaction between many components.
        &- It might not be reasonable to connect a debugger to every part of the system.

    ?- Many services shouldn't be stalled.
        &- Attaching a debugger often causes timeout failures.

    ?- Issues aren't always foreseen.
        &- Logging and tracing are designed for low overhead so that programs can always be recording in case an issue occurs.

< System.Console
    %- Always enabled and always writes to the console.
    %- Useful for information that your customer might need to see in the release.
    %- Because it's the simplest approach, it's often used for ad-hoc temporary debugging. This debug code is often never checked in to source control.

> System.Diagnostics.Trace
    %- Only enabled when TRACE is defined.
    %- Writes to attached Listeners, by default, the DefaultTraceListener.
    %- Use this API when you create logs that will be enabled in most builds.

? System.Diagnostics.Debug
    %- Only enabled when DEBUG is defined (when in debug mode).
    %- Writes to an attached debugger.
    %- Use this API when you create logs that will be enabled only in debug builds.

@ Define TRACE and DEBUG constants
    ^- By default, when an application is running under debug, the DEBUG constant is defined. This can be controlled by adding a DefineConstants entry in the project file in a property group.

    ^- Here's an example of turning on TRACE for both Debug and Release configurations in addition to DEBUG for Debug configurations:

        <PropertyGroup Condition="'$(Configuration)|$(Platform)'=='Debug|AnyCPU'">
            <DefineConstants>DEBUG;TRACE</DefineConstants>
        </PropertyGroup>

        <PropertyGroup Condition="'$(Configuration)|$(Platform)'=='Release|AnyCPU'">
            <DefineConstants>TRACE</DefineConstants>
        </PropertyGroup>

    ^- When you use Trace when not attached to the debugger, you'll need to configure a trace listener such as dotnet-trace.

* Conditional tracing
    ~- In addition to simple Write and WriteLine methods, there's also the capability to add conditions with WriteIf and WriteLineIf. As an example, the following logic checks if the count is zero and then writes a debug message.


! Verify that certain conditions exist
    $- An assertion, or Assert statement, tests a condition, which you specify as an argument to the Assert statement.
    $- If the condition evaluates to true, no action occurs. If the condition evaluates to false, the assertion fails.





*/

using System.Diagnostics;

namespace LoggingAndTracing
{

    public class OutputTypes
    {
        public static void WriteLineEx()
        {
            Console.WriteLine("WriteLine Example:");
            Console.WriteLine("\t- This message is readable by the end user.");
        }

        public static void TraceEx()
        {
            Console.WriteLine("Trace Example:");
            Trace.WriteLine("\t- This is a trace message when tracing the app.");
        }

        public static void DebugEx()
        {
            Console.WriteLine("Debug Example:");
            Debug.WriteLine("\t- This is a debug message just for developers.");

            Debug.Write("\tDebug - ");
            Debug.WriteLine("This is a full line.");
            Debug.WriteLine("\t- This is another full line.");
        }
    }

    public class ConditionalTracing
    {
        public static void ConditionalEx()
        {
            Console.WriteLine("Conditional Tracing Example:");
            int count = 0;

            Debug.WriteLineIf(count == 0, "\t- The count is 0 and this may cause an exception.");
        }

        public static void ConditionalEx2()
        {
            Console.WriteLine("Conditional Tracing Example 2:");
            bool errorFlag = false;
            Trace.WriteIf(errorFlag, "\t- Error in AppendData procedure.");
            Debug.WriteIf(errorFlag, "\t- Transaction abandoned.");
            Trace.Write("\t- Invalid value for data request");
        }
    }

    public class Assertions
    {
        public static int IntegerDivide(int dividend, int divisor)
        {
            Console.WriteLine("Assertion Example:");
            Debug.Assert(divisor != 0, $"\t- {nameof(divisor)} is 0 and will cause an exception.");

            return dividend / divisor;
        }
    }

    public class Program
    {
        public static void Select()
        {
            while (true)
            {
                try
                {

                    Console.WriteLine("Select Example:\n\t1. WriteLine\n\t2. Trace\n\t3. Debug\n\t4. Conditional\n\t5. Assertion\n\t6. Exit");
                    int selection = int.Parse(Console.ReadLine()!);

                    switch (selection)
                    {
                        case 1:
                            OutputTypes.WriteLineEx();
                            Console.WriteLine("\nPress anything to continue...\n");
                            Console.ReadKey(true);
                            continue;
                        case 2:
                            OutputTypes.TraceEx();
                            Console.WriteLine("\nPress anything to continue...\n");
                            Console.ReadKey(true);
                            continue;
                        case 3:
                            OutputTypes.DebugEx();
                            Console.WriteLine("\nPress anything to continue...\n");
                            Console.ReadKey(true);
                            continue;
                        case 4:
                            ConditionalTracing.ConditionalEx();
                            Console.WriteLine("\nPress anything to continue...\n");
                            Console.ReadKey(true);
                            continue;
                        case 5:
                            Assertions.IntegerDivide(10, 2);
                            Console.WriteLine("\nPress anything to continue...\n");
                            Console.ReadKey(true);
                            continue;
                        case 6:
                            Console.Write("Exiting...");
                            Thread.Sleep(1000);
                            return;
                        default:
                            Console.WriteLine("\nInvalid selection.\n");
                            Thread.Sleep(1000);
                            continue;
                    }
                }

                catch (FormatException ex)
                {
                    Console.WriteLine($"{ex.Message}\n\n");
                    Thread.Sleep(1000);
                }
            }
        }
        public static void Main()
        {
            Select();
            return;
        }
    }
}

