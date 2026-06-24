namespace TFLBank.Repository;
using TFLBank.model;

public interface IOperationRepository{
    List<Operation> GetAllOperations();

    bool SaveAllOperations (List<Operation> operations);


}