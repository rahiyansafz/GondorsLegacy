namespace GondorsLegacy.Services.Reservation.Constants;

public record Messages(string Message)
{
    public static Messages DefaultErrorMessage { get; } = new("An error occurred. Please try again later.");

    public static Messages InvalidReservationRequestMessage { get; } =
        new("An invalid reservation request was sent. Please check the request and try again.");

    public static Messages UnauthorizedOperationMessage { get; } =
        new("You are not authorized to perform this operation. Please log in or contact an administrator.");

    public static Messages ResourceNotFoundMessage { get; } =
        new("The specified resource was not found or does not exist.");

    public static Messages RequestTimeoutMessage { get; } = new("The request has timed out. Please try again.");

    public static Messages InvalidRequestFieldsMessage { get; } =
        new("Required fields in the request are missing or incorrect. Please check the request.");

    public static Messages SuccessMessage { get; } = new("Operation completed successfully.");
    public static Messages LoginRequiredMessage { get; } = new("User login is required. Please sign in.");
    public static Messages UserNotFoundMessage { get; } = new("User not found.");
    public static Messages AccessDeniedMessage { get; } = new("Access denied.");
    public static Messages InsufficientFundsMessage { get; } = new("Insufficient funds.");
    public static Messages DuplicateEntryMessage { get; } = new("Entry already exists, please try a different value.");
    public static Messages FileUploadErrorMessage { get; } = new("An error occurred while uploading the file.");
    public static Messages PasswordResetSuccessMessage { get; } = new("Password reset successfully completed.");
    public static Messages EmailConfirmationMessage { get; } = new("Email confirmation successful.");

    public static implicit operator string(Messages message) => message.Message;

    public override string ToString() => Message;
}