package orquestacionfinal;

import org.mule.api.MuleEventContext;

public class transformacionOfertas implements org.mule.api.lifecycle.Callable{
	
	public Object onCall(MuleEventContext eventContext) throws Exception {
		  String[] aux=eventContext.getMessage().getPayload().toString().split("=");
		  String result = "";
		  double a;
		  for(int x=2; x<5; x++){
			  String[] aux1 = aux[x].split(",");
			  result += "Proveedor "+ (x-1)+ ": \n";
				  result += " Profesor -> "+ aux1[0] +"�\n";
				  a = Double.parseDouble(aux1[0]);
				  result += " Material -> "+ aux1[1] +"�\n";
				  a += Double.parseDouble(aux1[1]);
				  result += " Profesor -> "+ aux1[2] +"�\n";
				  a += Double.parseDouble(aux1[2]);
				  result += " Alojamiento -> "+ aux1[3] +"�\n";
				  if(x != 4){
					  a += Double.parseDouble(aux1[3]);
				  }else{
					  a += Double.parseDouble(aux1[3].substring(0, aux1[3].length()-1));
				  }
				  result += " TOTAL -> "+ String.valueOf(a) + "�\n\n";
		  }
		  result = result.substring(0, result.length()-1);
		  return result;

	}
}
