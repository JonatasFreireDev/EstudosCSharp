using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    public class Example3
    {
        public static void FazerAlgo()
        {
            Console.WriteLine("Executando uma tarefa => FazendoAlgo() (task)");
        }

        //http://www.macoratti.net/13/05/c_task1.htm

        //Por razões de desempenho, o método StartNew da classe TaskFactory deve ser o mecanismo
        //preferido para criação e programação de tarefas, mas, para situações em que a criação
        //e programação devem ser separadas, os construtores podem ser usados, e o método Start()
        //da tarefa pode então ser utilizado para programar a tarefa para execução em um momento
        //posterior.

        //// usando factory task, maneiras diferentes de iniciar uma nova tarefa.
        //TaskFactory tf = new TaskFactory();
        //Task t1 = tf.StartNew(MetodoTarefa);

        //// usando a factor task via task
        //Task t2 = Task.Factory.StartNew(MetodoTarefa);

        //---------------------------------------------------------------------------------------------------

        //// usando o construtor Task
        //Task t3 = new Task(MetodoTarefa);
        //t3.Start();
    }
}