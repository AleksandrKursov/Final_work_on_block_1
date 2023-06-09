# **Итоговая проверочная работа.**

## **Для выполнения задания необходимо:**
1. Создать репозиторий на GitHub.
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод).
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md).
4. Написать программу, решающую поставленную задачу.
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что все залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах).

## **Условия задачи:**
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначально массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Например:**   
["hello","2","world",":-)"]->["2",":-)"]       
["1234","1567","-2","computer science"]->["-2"]     
["Russia","Denmark","Kazan"]->[]


## **Описание решения:**
1. В начале объявляется массив строк **myArray**, который с помощью метода **InputArray** приглашает пользователя заполнить его введением данных с клавиатуры (ввод выполняется в одной строке, при этом разделителем сдужит пробел - " ").

2. Заполненный массив строк **myArray** выводится в терминал с помощью метода **PrintArray**, в основе метода использованн стандартный строковый метод **string.Join** объединяющий подстроки в строку.

3. Результатом решения задачи должен быть новый массив строк в котором длина подстрок меньше либо равно 3. Для объявленияя нового массива строк необходимо определить длину нового массива. С этой целью объявлен целочисленный операнд **lengthNewArray**, который будет найден с помощью метода **FindingLengthNewArray**. Данный метод проходится циклом **for** по длине массива **myArray**, при этом если выполняется условие **if (arr[i].Length <= 3)** (если длина подстроки строчного массива меньше 3), то значение операнда **lengthNewArray** увеличивается на 1 (первоначально операнд **lengthNewArray** равен 0). По окончанию цикла метод возвращает операнд **lengthNewArray**, который содержит в себе значение длины нового массива.

4. Далее массив строк **myArray** и операнд **lengthNewArray** передаются в метод **ArraySorting**. В начале метода объевляется новый массив строк **sortedArray** размером **lengthNewArray** и целочисленный операнд **index** равный 0 (необходим для заполнения нового массива). Метод проходится циклом **for** по длине массива **myArray**, при этом если выполняется условие **if (arr[i].Length <= 3)**, то в подстроку нового массива **sortedArray** записывается подстрока из введенного массива **myArray** (**sortedArray[index] = arr[i]**), а также увеличивается значения операнда **index** на 1. По окончанию цикла метод возвращает заполненный массив строк **sortedArray**.

5. Заполненный массив строк **sortedArray** выводится в терминал с помощью метода **PrintArray**.

>Блок схема алгоритма находится в папке Block_diagram.