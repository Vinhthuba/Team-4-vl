using System.ComponentModel.DataAnnotations;

namespace Team_4.Models;
public class SanPham
{
    public int Id { get; set; }
    public string? TenSanpham { get; set; }
    public decimal Price { get; set; }
    
}
