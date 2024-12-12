﻿namespace SMSC.Types.Enums;

public enum StatusType
{
    /// <summary>
    /// (по умолчанию) получить статус сообщения в обычном формате.
    /// </summary>
    Default,
    /// <summary>
    /// Получить полную информацию об отправленном сообщении.
    /// </summary>
    Full,
    /// <summary>
    /// Добавить в информацию о сообщении данные о стране, операторе и регионе абонента.
    /// </summary>
    Additional
}
