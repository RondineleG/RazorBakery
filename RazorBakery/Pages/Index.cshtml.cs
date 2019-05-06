using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorBakery.Data;
using RazorBakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorBakery.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RazorBakeryContext db;  
        public IndexModel(RazorBakeryContext db) => this.db = db;
        public List<Produto> Produtos { get; set; } = new List<Produto>();  
        public IndexModel(Produto produtoDestaque) 
        {
            this.ProdutoDestaque = produtoDestaque;
               
        }
                public Produto ProdutoDestaque { get; set; }  
        public async Task OnGetAsync()
        {
            Produtos = await db.Produtos.ToListAsync();
            ProdutoDestaque = Produtos.ElementAt(new Random().Next(Produtos.Count));
        }
    }
}
