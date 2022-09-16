public class Cafetera {
	private int capacidadMaxima;
	private int cantidadActual;
	
	public Cafetera() {
	this.capacidadMaxima = 1000;
	this.cantidadActual = 0;
		
	}
	
	public Cafetera (int capacidadMaxima) {
	this.capacidadMaxima = capacidadMaxima;
	this.cantidadActual = capacidadMaxima;
		
	}
	
	public Cafetera (int capacidadMaxima, int cantidadActual) {
		this.capacidadMaxima = capacidadMaxima;
		if(cantidadActual > capacidadMaxima){
			this.cantidadActual = capacidadMaxima;
			
		}else {
			this.cantidadActual = cantidadActual;
		}
		
	}
	
	  public int getcapacidadMaxima() {
	        return this.capacidadMaxima;
	    }

	    public void setcapacidadMaxima(int capacidadMaxima) {
	        this.capacidadMaxima = capacidadMaxima;
	    }

	    public int getcantidadActual() {
	        return this.cantidadActual;
	    }

	    public void setcantidadActual(int cantidadActual) {
	        this.cantidadActual = cantidadActual;
	    }
	    
	    public void llenarCafetera() {
	    	this.cantidadActual = this.capacidadMaxima;
	    }
	    
	    public void servirTaza(int cantidad){
	    	if(cantidad < this.cantidadActual){
	    		
	    		this.cantidadActual = this.cantidadActual - cantidad;
	    	}else {
	    		this.cantidadActual = 0;
	    	}
	    	
	    }
	    
	    public void vaciarCafetera() {
	    	this.cantidadActual = 0;
	    	
	    }
	    
	    public void agregarCafe(int cantidad) {
	    	this.cantidadActual = Math.min(this.capacidadMaxima, this.cantidadActual +  cantidad);
	    	
	    }
	
	

}
