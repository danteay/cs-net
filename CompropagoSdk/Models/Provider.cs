﻿
namespace CompropagoSdk.Models
{
    public class Provider
    {
        public string name { get; set; }
        public string store_image { get; set; }
        public bool is_active { get; set; }
        public string internal_name { get; set; }
        public string image_small { get; set; }
        public string image_medium { get; set; }
        public string image_large { get; set; }
        public float transaction_limit { get; set; }
        public int rank { get; set; }
    }
}
