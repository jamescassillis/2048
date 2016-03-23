Public Class Gamefrm
  Public map(,) as integer
  Public Function move(byval direction as string,byval map(,) as integer)
    if direction="down" then
    	for i=2 to 0 step -1
    		for j=3 to 0 step -1
    			if map(i,j)<>0 then 
    				if map(i+1,j)=0 then
    					map(i+1,j)=map(i,j)
    					map(i,j)=0
    				elseif map(i+1,j)=map(i,j) then
    					map(i+1,j)=map(i,j)*2
    					map(i,j)=0
    				end if
    			end if
    		next
    	next
    elseif direction="up" then
    	for i=1 to 3
    		for j=0 to 
    			if map(i,j)<>0 then
    				if map(i-1,j)=0 then
    					map(i-1,j)=map(i,j)
    					map(i,j)=0
    				elseif map(i-1,j=map(i,j) then
	    				map(i-1,j)=map(i,j)*2
	    				map(i,j)=0
    				end if
    			end if
    		next
    	next
    elseif direction="left" then
    	for i=0 to 3
    		for j=1 to 3
    			if map(i,j)<>0 then
    				if map(i,j-1)=0 then
    					map(i,j-1)=map(i,j)
    					map(i,j)=0
    				elseif map(i,j-1)=map(i,j) then
    					map(i,j-1)=map(i,j)*2
    				end if
    				
    			end if
    		next
    	next
    elseif direction="right" then
    	for i=0 to 3
    		for j=2 to 0 step -1
    			if map(i,j)<>0 then
    				if map(i,j+1)=0 then
    					map(i,j+1)=map(i,j)
    					map(i,j)=0
    				elseif map(i,j+1)=map(i,j) then
    					map(i,j+1)=map(i,j) *2
    					map(i,j)=0
    				end if
    			end if
    		next
    	next
    	
    end if
  End Function
End Class
