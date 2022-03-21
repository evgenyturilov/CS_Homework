// Найти расстояние между точками в пространстве 2D/3D

int firstPointCoordX = 17;
int firstPointCoordY = 23;
int secondPointCoordX = 35;
int secondPointCoordY = 25;

int sideOfTriangleA = firstPointCoordX - secondPointCoordX;
int sideOfTriangleB = firstPointCoordY - secondPointCoordY;

var distanceBetweenPoints = Math.Sqrt(sideOfTriangleA*sideOfTriangleA + sideOfTriangleB*sideOfTriangleB);
Console.WriteLine(distanceBetweenPoints);
