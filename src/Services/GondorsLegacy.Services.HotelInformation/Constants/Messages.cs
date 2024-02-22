namespace GondorsLegacy.Services.HotelInformation.Constants;

public record Messages(string Message)
{
    public static Messages DefaultErrorMessage { get; } = new Messages("An error occurred. Please try again later.");
    public static Messages HotelNotFound { get; } = new Messages("Hotel not found");

    public static Messages InvalidHotelRequestMessage { get; } =
        new Messages("An invalid hotel request was sent. Please check the request and try again.");

    public static Messages HotelAddedSuccessfully { get; } = new Messages("Hotel added successfully");
    public static Messages HotelUpdatedSuccessfully { get; } = new Messages("Hotel updated");
    public static Messages HotelDeletedSuccessfully { get; } = new Messages("Hotel deleted");

    public static Messages EmptyOrInvalidParameters { get; } =
        new Messages("A hotel request was sent with empty or invalid parameters");

    public static Messages RequestProcessedSuccessfully { get; } = new Messages("Request processed successfully");
    public static implicit operator string(Messages message) => message.Message;

    public override string ToString() => $"{nameof(Messages)}";
}