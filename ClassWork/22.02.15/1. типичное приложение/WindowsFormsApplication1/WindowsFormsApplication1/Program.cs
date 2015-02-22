﻿using System;
using System.Windows.Forms;

// пространство System.Windows.Forms содержит набор классов, отвечающих в .Net Framework за создание графического интерфейса пользователя.
// Все типы этого пространства (классы, интерфейсы, делегаты, структуры) можно разделить на следующие категории:
// 1) Базовая инфраструктура - это типы данных, представляющие базовые операции программы. Например, Forms и Application;
// 2) Элементы управления - типы, которые применяются для создания графических пользовательских интерфейсов.
// Например, CheckBox, TextBox, Button, RadioButton. Все эти типы являются производными от класса Control;
// 3) Компоненты - типы, которые не порождены от класса Control, НО все-таки могут предоставлять визуальные возможности программы WindowsForms.
// Есть компоненты, которые не имеют визуального отображения, например, таймер;
// 4) Окна стандартных диалогов. В WinForms имеется несколько типов, предоставляющих работу со стандартными диалоговыми окнами. Например, OpenFileDialog.


namespace WindowsFormsApplication1
{
    static class Program
    {
        // STA-single-threaded apartment 
        // данный аттрибут функция Main() должна иметь во всех windows-приложениях.
        // Это означает,что все потоки в этой программе выполняются в рамках одного процесса, а управление программой
        // осуществляется одним главным потоком. Эту нужно, чтобы в дальнейшем не было проблем, если приложение подключает
        // сторонние компоненты. Разработчики компонентов могут дать своему компоненту слишком много прав. Вы подключили компонент
        // он запускает какое-то модальное действие и ваша прога зависает. При STA всеми потоками руководит поток, запущеный с Main().
        [STAThread]
        static void Main()
        {
            // Класс Application

            // Предназначен для операций с приложением. Например, запуск очереди сообщений приложения, получение информации о приложении, и т.д.
            // Метод Run() - запускает стандартный цикл обработки сообщений в текущем потоке и делает указанную форму видимой.

            // Этот метод включает визуальные стили приложения. Элементы управления будут прорисовываться
            // с помощью визуальных стилей, если элемент управления и операционная система поддерживает их. Чтобы добиться эффекта,
            // следует вызвать метод EnableVisualStyles() перед созданием элементов управления в приложении; как правило,
            // метод EnableVisualStyles() представлен первой строкой в функции Main. Для включения визуальных стилей при
            // вызове метода EnableVisualStyles() отдельный манифест не требуется.
            // настройка манифеста: http://msdn.microsoft.com/en-us/library/aa289524%28v=VS.71%29.aspx

            // Некоторые элементы управления Windows Forms могут визуализировать свой текст, используя либо графическую библиотеку GDI,
            // либо более новую библиотеку GDI+. Это изменение было сделано в связи с проблемами производительности и трудностями
            // локализации, возникшими при использовании GDI+. По умолчанию для существующих элементов управления, поддерживающих
            // свойство UseCompatibleTextRendering, задано значение true для обеспечения обратной совместимости, однако во всех
            // элементах управления, включенных в Windows Forms 2.0 или более поздней версии, для этого свойства задано значение false.
            // Используйте метод SetCompatibleTextRenderingDefault, когда требуется переключить визуализацию текста, используемую
            // по умолчанию, для новых элементов управления.
            // http://msdn.microsoft.com/ru-ru/library/system.windows.forms.application.setcompatibletextrenderingdefault(v=vs.90).aspx

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
