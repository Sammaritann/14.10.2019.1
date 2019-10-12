## 14.10.2019.1 (deadline - )

1. Форкнуть данный репозиторий.
2. Склонировать свою ветку к себе на десктоп.
3. Заполнить проекты EnumerableExtension и EnumerableExtension.Tests необходимой функциональностью.
4. Синхронизировать изменения с содержимым своего репозитория на gitub-e.
5. Сделать pull request к данному репозиторию.

## Постановка задания
- Добавить в класс ArrayExtension (класс переименовать в EnumerableExtension) [Day 9. 03.10.2019](https://github.com/AnzhelikaKravchuk/.NET-Training.-Autumn-2019#-%D0%B7%D0%B0%D0%B4%D0%B0%D1%87%D0%B8-6) перегруженные версии обобщенно-типизированных методов расширений типизированного интерфейса `IEnumerable<T>`, используя в качестве передаваемых параметов (стратегий фильтрации, трансформации, сравнения) соответствующие делегаты 
  - [`Predicate<T>`](https://docs.microsoft.com/en-us/dotnet/api/system.predicate-1?view=netframework-4.8) 
  - [`Converter<TInput,TOutput>`](https://docs.microsoft.com/en-us/dotnet/api/system.converter-2?view=netframework-4.8)
  - [`Comparison<T>`](https://docs.microsoft.com/en-us/dotnet/api/system.comparison-1?view=netframework-4.8)

- При реализации "методов-двойников" использовать:
    - для методов (Filter, OrderAccordingTo) с параметрами делегатами вызовы методов с параметром интерфейсом;
    - для метода (Transform) с параметром интерфейсом вызов метода с параметром делегатом.
- Проверить работу разработанных методов, используя различные типы данных.
