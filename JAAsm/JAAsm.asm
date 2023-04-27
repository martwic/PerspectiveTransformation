.data
.code
; PARAMETERS:
; RCX = pictureNew
; RDX = toChange
; R8 = size
; R9 = x

MyProc1 proc
		push rsi
		push rdi
		mov	 rdi, r8	;rdi - iterator - in size of toChange array
		mov	 r11, 0		;r11 - index added to current position in toChange array
		mov  r15, rdx	;r15 - address of toChange array
		mov  r14, rcx   ;r14 - address of pictureNew array
	tLoop:
		cmp	 rdi, 0h	;check if iterator is 0					
		je	 endLoop	;if it is - jump to the endLoop					

		mov r12, 0		
		mov r13, 0

		mov	r12d, dword ptr[r15+r11]				; k from toChange (first element of pair in two dimensional array)
		mov	r13d, dword ptr[r15+r11+4]				; j from toChange (second element of pair in two dimensional array)

		sub	r12d , 1d		;k-1

		mov rax, 0
		mov AL, 3
		mul	r12			
		mov r12, rax		;(k-1)*3	

		mov rax, 0
		mov AL, 3
		mul	r13	
		mov r13, rax		;j*3

		mov rax, R9
		mul	r13	
		mov r13, rax		;j*3*x (x would be length of row in two dimensional array array)

		add	r12,r13			;(k-1)*3 + j*3*x
		add	r12, r14		;(k-1)*3 + j*3*x plus address of pictureNew array


		movlps xmm3, qword ptr[r12+3] ;element before pixel to change
		PSlLDQ xmm3, 5
		PSrLDQ xmm3, 5				  ;this is to get rid of unneeded colour part
		movlps xmm4, qword ptr[r12-3] ;element after pixel to change
		PSlLDQ xmm4, 5
		PSrLDQ xmm4, 5				  ;this is to get rid of unneeded colour part
		
		pavgb  xmm3, xmm4			  ;averages of colours parts

		movd ebx, xmm3	
		
		mov byte ptr[r12] ,bl		  ;writing colour of pixel to pictureNew array, but colour parts goes one by one
		shr ebx, 8
		mov byte ptr[r12+1] ,bl
		shr ebx, 8
		mov byte ptr[r12+2] ,bl

	
		add			r11, 8			 ;increment index which is added to current position in toChange array		
		sub			rdi, 2			 ;decrement iterator 
		jmp			tLoop			 ;back to start of loop		

endLoop:	

		pop rdi
		pop rsi
ret
MyProc1 endp
end
