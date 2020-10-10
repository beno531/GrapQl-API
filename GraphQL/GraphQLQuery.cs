using Newtonsoft.Json.Linq;

namespace GrapQl_API.GraphQL
{
  public class GraphQLQuery
  {
    public string OperationName { get; set; }
    public string NamedQuery { get; set; }
    public string Query { get; set; }
    public JObject Variables { get; set; }
  }
}