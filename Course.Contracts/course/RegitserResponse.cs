namespace Course.Contracts.course;


public record RegisterResponse(
    string Name,
    string Email,
    string Password
);