public class Producto{
    private String nombreProducto;
	private int numeroLote;

    public Producto(String nombreProducto, int numeroLote){
        this.nombreProducto = nombreProducto;
        this.numeroLote = numeroLote
    }

    public String getNombreProducto() {
		return this.nombreProducto;
		
	}
	
	public void setNombreProducto(String nombreProducto) {
		this.nombreProducto = nombreProducto;
		
	}

    public int getNumeroLote(int numeroLote){
        return this.numeroLote;
    }

    public void setnumeroLote(int numeroLote) {
		this.numeroLote = numeroLote;
		
	}

    public void mostrar() {
		System.out.println(this.nombreProducto);
		System.out.println(this.numeroLote);
	}

    

}