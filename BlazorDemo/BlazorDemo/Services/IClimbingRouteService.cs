namespace BlazorDemo.Services;

public interface IClimbingRouteService
{
    List<ClimbingRouteModel> GetAll();

    void Add(ClimbingRouteModel route);

    void Remove(ClimbingRouteModel route);
}