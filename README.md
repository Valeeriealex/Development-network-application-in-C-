# Development-of-a-network-application-in-C-

## **Сетевые протоколы**

  **IPAddress[] adredress = Dns.GetHostAddresses(host, System.Net.Sockets.AddresFamily.InterNetwork);**

  Класс **= new Ping ()**
  Позволяет приложению определить, доступен ли удаленный компьютер по сети.


* **TCP** - первичный, гарантирует упорядоченную доставку данных от пользователя к серверу (и наоборот).
* **UDP** - не гарантирует отправку сообщений, доставляет пакеты вразнобой, но бысрее при условии одинакого количества данных.
* **HTTP**-сообщения представляют собой обычный текст, поэтому неавторизованные лица могут легко получить к ним доступ и прочитать их через Интернет.
* **HTTPS** передает все данные в зашифрованном виде.
* **DNS** - не требует установки соединений перед отправкой

  ## **Синхронизация**
  
  Есть два вида синхронизации — односторонняя и двусторонняя в **многопоточности**.
  Класс **= new Thread(() => Function(x, y))**
  Позволяет одному потоку передать выполнение другому потоку.
  Потоки бывают — главные и фоновые.
  Критическая секция - это блок кода, исполняемы определенным потоком в один момент времени.
  ThreadPool - многопоточность в процессоре.
  Thread - один процессор.
  Необработанное завершение в потоке приведет к завершению приложения.
  ref не используется в многопоточности.

  ## **Асинхронность**
  
  Позволяет вынести отдельные задачи из основного потока в специальные асинхронные методы и при этом более экономно использовать потоки.
  Ключевыми для работы с асинхронными вызовами являются два оператора: **async** - помогает правильно скомпилировать метод и **await** - помогает дождаться выполнения операции и не выполнять код дальше.

```class Program
{
    async static Task Main(string[] args)
    {
        await PrintAsync();   // вызов асинхронного метода
        Console.WriteLine("Некоторые действия в методе Main");
 
 
        void Print()
        {
            Thread.Sleep(3000);     // имитация продолжительной работы
            Console.WriteLine("Hello METANIT.COM");
        }
 
        // определение асинхронного метода
        async Task PrintAsync()
        {
            Console.WriteLine("Начало метода PrintAsync"); // выполняется синхронно
            await Task.Run(() => Print());                // выполняется асинхронно
            Console.WriteLine("Конец метода PrintAsync");
        }
    }
}
```
  
  
