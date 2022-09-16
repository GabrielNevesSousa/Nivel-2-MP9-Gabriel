public class ProductoFresco extends Producto{

private String fechaEnvasado;
	private String paisOrigen;
	
	public ProductoFresco(String nombreProducto, int numeroLote, String fechaEnvasado, String paisOrigen) {
		super(nombreProducto, numeroLote);
		this.fechaEnvasado = fechaEnvasado;
		this.paisOrigen = paisOrigen;
	}
	
	public String getfechaEnvasado() {
		return this.fechaEnvasado;
		
	}
	
	public void setfechaEnvasado(String fechaEnvasado) {
		this.fechaEnvasado = fechaEnvasado;
		
	}
	
	public String getPaisOrigen() {
		return paisOrigen;
	}
	
	public void setPaisOrigen(String paisOrigen) {
		this.paisOrigen = paisOrigen;
		
	}
	
	public void mostrarProductoFresco() {
		super.mostrar();
		System.out.println(this.fechaEnvasado);
		System.out.println(this.paisOrigen);
	}

}