using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace APPPARCIAL2.Models
{
  
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;


namespace APPPARCIAL2.Models
{
    public partial class Instrucciones
    {
        [JsonProperty("albumId")]
        public long AlbumId { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("thumbnailUrl")]
        public Uri ThumbnailUrl { get; set; }
        }

