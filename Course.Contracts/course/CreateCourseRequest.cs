namespace Course.Contracts.course;


public record CreateRegisterRequest(
    string Name,
    string Email,
    string Password
);