
// esta classe represena o payload para requisições em Product, evitando, assim, de passar a própria entidade na requisição.
public record ProductRequest(string Code, string Name, string Description, int CategoryId, List<string> Tags);
