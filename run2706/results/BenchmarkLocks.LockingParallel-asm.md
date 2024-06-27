## .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
```assembly
; BenchmarkLocks.LockingParallel.NoLock()
;             Parallel.For(0, max_runs_per_invoke, (_) =>
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             {
;              
;                 unchecked { value += 1; }
;                                          
;             });
;                
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+80]
       mov       rbx,rcx
       mov       rcx,offset MT_System.Action`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+18]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB8BEC0D20
       mov       [rsi+18],rcx
       mov       rcx,22543804A50
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       [rsp+28],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-30]
       mov       r9d,edi
       mov       rdx,offset MD_System.Threading.Tasks.Parallel.ForWorker[[System.Object, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.Object,System.Object>, System.Func`1<System.Object>, System.Action`1<System.Object>)
       xor       r8d,r8d
       call      qword ptr [7FFB8C0D6598]; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 147
```
```assembly
; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-98],rsp
       mov       [rbp-38],rdx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L02
M01_L00:
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       [rbp-90],r8
       lea       rcx,[r8+10]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-90]
       lea       rcx,[r8+28]
       mov       rdx,[rbp+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-90]
       lea       rcx,[r8+30]
       mov       rdx,[rbp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-90]
       lea       rcx,[r8+38]
       mov       rdx,[rbp+50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-90]
       lea       rcx,[r8+40]
       mov       rdx,[rbp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-90]
       lea       rcx,[r8+48]
       mov       rdx,[rbp+58]
       call      CORINFO_HELP_ASSIGN_REF
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       r9d,[rbp+28]
       cmp       r9d,[rbp+20]
       jle       short M01_L01
       mov       rcx,offset MT_System.Threading.Tasks.ParallelLoopStateFlags`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+0C],7FFFFFFF
       mov       r8,[rbp-90]
       lea       rcx,[r8+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-90]
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-68],rcx
       cmp       qword ptr [rbp-68],0
       je        near ptr M01_L04
       mov       rcx,[rbp-68]
       cmp       dword ptr [rcx+20],0
       je        near ptr M01_L04
       jmp       near ptr M01_L23
M01_L01:
       mov       r8,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [r8],xmm0
       mov       rax,[rbp-40]
       mov       [r8+10],rax
       mov       byte ptr [r8],1
       mov       rax,r8
       add       rsp,0A0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       rcx,rdx
       mov       rdx,7FFB8C0E19F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L03:
       mov       r15,r8
       mov       byte ptr [r14+1C],0
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Threading.Tasks.IndexRange[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M01_L12
       jmp       near ptr M01_L10
M01_L04:
       mov       rcx,[r8+10]
       mov       ebx,[rcx+10]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        near ptr M01_L24
M01_L05:
       mov       rax,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [rcx],rax
       jne       near ptr M01_L25
       mov       esi,7FFFFFFF
M01_L06:
       test      esi,esi
       jle       short M01_L07
       cmp       esi,7FFFFFFF
       jne       near ptr M01_L26
M01_L07:
       cmp       ebx,0FFFFFFFF
       jne       short M01_L09
       mov       ebx,14
M01_L08:
       movsxd    rsi,dword ptr [rbp+20]
       movsxd    rdi,dword ptr [rbp+28]
       mov       rcx,offset MT_System.Threading.Tasks.RangeManager
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       eax,eax
       mov       [r14+18],eax
       mov       qword ptr [r14+10],1
       mov       eax,2
       cmp       ebx,1
       cmove     ebx,eax
       mov       rcx,rdi
       sub       rcx,rsi
       movsxd    r8,ebx
       mov       rax,rcx
       xor       edx,edx
       div       r8
       mov       r8,rax
       mov       eax,1
       test      r8,r8
       cmove     r8,rax
       mov       rax,rcx
       xor       edx,edx
       div       r8
       mov       ebx,eax
       mov       rax,rcx
       xor       edx,edx
       div       r8
       test      rdx,rdx
       jne       near ptr M01_L29
       jmp       near ptr M01_L03
M01_L09:
       mov       rcx,[r8+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0D7168]; System.Threading.Tasks.ParallelOptions.get_EffectiveMaxConcurrencyLevel()
       mov       ebx,eax
       jmp       near ptr M01_L08
M01_L10:
       mov       rax,[r14+8]
       cmp       r13d,[rax+8]
       jae       near ptr M01_L31
       mov       ecx,r13d
       shl       rcx,5
       lea       rax,[rax+rcx+10]
       mov       [rax+8],rsi
       xor       r8d,r8d
       mov       [rax],r8
       mov       rax,[r14+8]
       cmp       r13d,[rax+8]
       jae       near ptr M01_L31
       lea       rax,[rax+rcx+10]
       mov       [rax+18],r8d
       add       rsi,r15
       mov       rcx,rsi
       sub       rcx,r15
       cmp       rcx,rsi
       jg        near ptr M01_L19
       cmp       rsi,rdi
       jg        near ptr M01_L19
M01_L11:
       mov       [rax+10],rsi
       inc       r13d
       cmp       r13d,ebx
       jl        short M01_L10
M01_L12:
       mov       r8,[rbp-90]
       lea       rcx,[r8+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       r8,[rbp-90]
       mov       [r8+8],rcx
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-68],rcx
       cmp       qword ptr [rbp-68],0
       jne       near ptr M01_L22
       xor       ecx,ecx
       xor       eax,eax
M01_L13:
       mov       [rbp-60],rcx
       mov       [rbp-58],rax
       xor       ecx,ecx
       mov       [r8+50],ecx
       mov       rcx,22543804A70
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M01_L30
M01_L14:
       mov       rcx,offset MT_System.Threading.Tasks.TaskReplicator+ReplicatableUserAction`1[[System.Threading.Tasks.RangeWorker, System.Threading.Tasks.Parallel]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFB8C0D3750
       mov       [r13+18],rdx
       mov       rdx,[rbp-90]
       mov       rdx,[rdx+10]
       mov       rcx,r13
       mov       r8d,1
       call      qword ptr [7FFB8C0DC948]; System.Threading.Tasks.TaskReplicator.Run[[System.Threading.Tasks.RangeWorker, System.Threading.Tasks.Parallel]](ReplicatableUserAction`1<System.Threading.Tasks.RangeWorker>, System.Threading.Tasks.ParallelOptions, Boolean)
       nop
       mov       rdx,[rbp-90]
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-68],rcx
       cmp       qword ptr [rbp-68],0
       je        short M01_L16
       lea       rcx,[rbp-60]
       call      qword ptr [7FFB8C0D7798]
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rdx+8]
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rdx,[rbp-90]
       cmp       qword ptr [rdx+8],0
       jne       short M01_L15
       jmp       short M01_L18
M01_L17:
       nop
       mov       rdx,[rbp-90]
M01_L18:
       mov       rcx,rsp
       call      M01_L33
       nop
       mov       r8,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [r8],xmm0
       mov       rax,[rbp-40]
       mov       [r8+10],rax
       movzx     eax,byte ptr [rbp-84]
       mov       [r8],al
       mov       rax,r8
       add       rsp,0A0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       rsi,rdi
       jmp       near ptr M01_L11
M01_L20:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       lea       rdx,[rbp-80]
       mov       r8,r14
       xor       r9d,r9d
       call      qword ptr [7FFB8C174D98]
M01_L21:
       mov       rcx,[rbp-80]
       mov       rax,[rbp-78]
       mov       r8,[rbp-90]
       jmp       near ptr M01_L13
M01_L22:
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-68],rcx
       mov       rcx,offset MT_System.Action`1[[System.Object, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset System.Threading.Tasks.Parallel+<>c__DisplayClass19_0`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].<ForWorker>b__0(System.Object)
       mov       [r14+18],rdx
       mov       rcx,[rbp-68]
       test      rcx,rcx
       jne       short M01_L20
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-80],xmm0
       jmp       short M01_L21
M01_L23:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFB8BE65740]
       int       3
M01_L24:
       call      qword ptr [7FFB8C0D72A0]
       mov       rcx,22543800918
       test      rax,rax
       cmove     rax,[rcx]
       mov       rcx,rax
       mov       r8,[rbp-90]
       jmp       near ptr M01_L05
M01_L25:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       esi,eax
       mov       r8,[rbp-90]
       jmp       near ptr M01_L06
M01_L26:
       cmp       ebx,0FFFFFFFF
       je        short M01_L27
       cmp       esi,ebx
       cmovg     esi,ebx
       mov       ebx,esi
       jmp       short M01_L28
M01_L27:
       mov       ebx,esi
M01_L28:
       jmp       near ptr M01_L07
M01_L29:
       inc       ebx
       jmp       near ptr M01_L03
M01_L30:
       mov       rax,7FFB8C0CE350
       mov       ecx,1
       lock xadd [rax],ecx
       inc       ecx
       mov       r8,[rbp-90]
       mov       [r8+50],ecx
       mov       rax,22543804A70
       mov       rbx,[rax]
       call      qword ptr [7FFB8C0D72A0]
       mov       rcx,rax
       mov       rax,22543800918
       test      rcx,rcx
       cmove     rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0D72D0]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       esi,eax
       call      qword ptr [7FFB8BE64420]
       mov       [rbp-70],rax
       mov       r8d,[rbp-6C]
       mov       rax,[rbp-90]
       mov       r9d,[rax+50]
       movsxd    rcx,dword ptr [rbp+20]
       movsxd    rdx,dword ptr [rbp+28]
       mov       dword ptr [rsp+20],2
       mov       [rsp+28],rcx
       mov       [rsp+30],rdx
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFB8C0DC798]
       jmp       near ptr M01_L14
M01_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0D0]
       mov       rax,[rbp-90]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       mov       [rbp-68],rcx
       cmp       qword ptr [rbp-68],0
       je        short M01_L32
       lea       rcx,[rbp-60]
       call      qword ptr [7FFB8C0D7798]
M01_L32:
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0D0]
       mov       rbx,rdx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0D7A38]
       mov       rsi,rax
       mov       rax,[rbp-90]
       mov       rcx,[rax+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0D7138]; System.Threading.Tasks.ParallelOptions.get_CancellationToken()
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFB8C0D63D0]
       lea       rax,[M01_L17]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L33:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0D0]
       mov       rdx,[rbp-90]
       mov       rax,[rdx+18]
       mov       esi,[rax+8]
       xor       eax,eax
       test      esi,esi
       sete      al
       mov       [rbp-84],eax
       test      sil,2
       je        short M01_L34
       mov       rdx,[rbp-90]
       mov       rcx,[rdx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0D7C48]
       movsxd    rcx,eax
       mov       byte ptr [rbp-48],1
       mov       [rbp-40],rcx
M01_L34:
       mov       rax,22543804A70
       mov       rax,[rax]
       cmp       byte ptr [rax+9D],0
       je        near ptr M01_L38
       test      esi,esi
       jne       short M01_L35
       mov       r9d,[rbp+28]
       mov       ebx,r9d
       sub       ebx,[rbp+20]
       jmp       short M01_L37
M01_L35:
       test      sil,2
       je        short M01_L36
       mov       rdx,[rbp-90]
       mov       rcx,[rdx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0D7C48]
       mov       ebx,eax
       sub       ebx,[rbp+20]
       jmp       short M01_L37
M01_L36:
       mov       ebx,0FFFFFFFF
M01_L37:
       mov       rax,22543804A70
       mov       rsi,[rax]
       call      qword ptr [7FFB8C0D72A0]
       mov       rcx,rax
       mov       rax,22543800918
       test      rcx,rcx
       cmove     rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0D72D0]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       edi,eax
       call      qword ptr [7FFB8BE64420]
       mov       [rbp-70],rax
       mov       r8d,[rbp-6C]
       mov       rax,[rbp-90]
       mov       r9d,[rax+50]
       movsxd    rcx,ebx
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FFB8C0DC7B0]
M01_L38:
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1931
```

## .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
```assembly
; BenchmarkLocks.LockingParallel.Parallel_UseLock()
;             Parallel.For(0, max_runs_per_invoke, (_) =>
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             {
;              
;                 UseLock();
;                           
;             });
;                
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+80]
       mov       rbx,rcx
       mov       rcx,offset MT_System.Action`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+18]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB8BEF0D38
       mov       [rsi+18],rcx
       mov       rcx,1BDFF804A50
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       [rsp+28],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-30]
       mov       r9d,edi
       mov       rdx,offset MD_System.Threading.Tasks.Parallel.ForWorker[[System.Object, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.Object,System.Object>, System.Func`1<System.Object>, System.Action`1<System.Object>)
       xor       r8d,r8d
       call      qword ptr [7FFB8C1064F0]; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 147
```
```assembly
; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       vzeroupper
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       [rbp-60],rax
       mov       [rbp-0A8],rsp
       mov       [rbp-40],rdx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L02
M01_L00:
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       [rbp-98],r8
       lea       rcx,[r8+10]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-98]
       lea       rcx,[r8+28]
       mov       rdx,[rbp+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-98]
       lea       rcx,[r8+30]
       mov       rdx,[rbp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-98]
       lea       rcx,[r8+38]
       mov       rdx,[rbp+50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-98]
       lea       rcx,[r8+40]
       mov       rdx,[rbp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-98]
       lea       rcx,[r8+48]
       mov       rdx,[rbp+58]
       call      CORINFO_HELP_ASSIGN_REF
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-58],xmm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       r9d,[rbp+28]
       cmp       r9d,[rbp+20]
       jle       short M01_L01
       mov       rcx,offset MT_System.Threading.Tasks.ParallelLoopStateFlags`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+0C],7FFFFFFF
       mov       r8,[rbp-98]
       lea       rcx,[r8+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-98]
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-70],0
       je        near ptr M01_L05
       mov       rcx,[rbp-70]
       cmp       dword ptr [rcx+20],0
       je        near ptr M01_L05
       jmp       near ptr M01_L24
M01_L01:
       mov       r8,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rbp-58]
       vmovdqu   xmmword ptr [r8],xmm0
       mov       rax,[rbp-48]
       mov       [r8+10],rax
       mov       byte ptr [r8],1
       mov       rax,r8
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       rcx,rdx
       mov       rdx,7FFB8C1119F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L03:
       mov       r15,r8
       mov       byte ptr [r14+1C],0
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Threading.Tasks.IndexRange[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M01_L13
M01_L04:
       mov       rcx,[r14+8]
       cmp       r13d,[rcx+8]
       jae       near ptr M01_L32
       mov       edx,r13d
       shl       rdx,5
       lea       rcx,[rcx+rdx+10]
       mov       [rcx+8],rsi
       xor       eax,eax
       mov       [rcx],rax
       mov       rcx,[r14+8]
       cmp       r13d,[rcx+8]
       jae       near ptr M01_L32
       lea       r12,[rcx+rdx+10]
       mov       [r12+18],eax
       add       rsi,r15
       mov       rcx,rsi
       sub       rcx,r15
       cmp       rcx,rsi
       jg        near ptr M01_L20
       jmp       near ptr M01_L11
M01_L05:
       mov       rcx,[r8+10]
       mov       ebx,[rcx+10]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        near ptr M01_L25
M01_L06:
       mov       rax,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [rcx],rax
       jne       near ptr M01_L26
       mov       esi,7FFFFFFF
M01_L07:
       test      esi,esi
       jle       short M01_L08
       cmp       esi,7FFFFFFF
       jne       near ptr M01_L27
M01_L08:
       cmp       ebx,0FFFFFFFF
       jne       short M01_L10
       mov       ebx,14
M01_L09:
       movsxd    rsi,dword ptr [rbp+20]
       movsxd    rdi,dword ptr [rbp+28]
       mov       rcx,offset MT_System.Threading.Tasks.RangeManager
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       eax,eax
       mov       [r14+18],eax
       mov       qword ptr [r14+10],1
       mov       eax,2
       cmp       ebx,1
       cmove     ebx,eax
       mov       rcx,rdi
       sub       rcx,rsi
       movsxd    r8,ebx
       mov       rax,rcx
       xor       edx,edx
       div       r8
       mov       r8,rax
       mov       eax,1
       test      r8,r8
       cmove     r8,rax
       mov       rax,rcx
       xor       edx,edx
       div       r8
       mov       ebx,eax
       mov       rax,rcx
       xor       edx,edx
       div       r8
       test      rdx,rdx
       jne       near ptr M01_L30
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,[r8+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C1070C0]; System.Threading.Tasks.ParallelOptions.get_EffectiveMaxConcurrencyLevel()
       mov       ebx,eax
       jmp       near ptr M01_L09
M01_L11:
       cmp       rsi,rdi
       jg        near ptr M01_L20
M01_L12:
       mov       [r12+10],rsi
       inc       r13d
       cmp       r13d,ebx
       jl        near ptr M01_L04
M01_L13:
       mov       r8,[rbp-98]
       lea       rcx,[r8+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       r8,[rbp-98]
       mov       [r8+8],rcx
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-70],0
       jne       near ptr M01_L23
       xor       ecx,ecx
       xor       eax,eax
M01_L14:
       mov       [rbp-68],rcx
       mov       [rbp-60],rax
       xor       ecx,ecx
       mov       [r8+50],ecx
       mov       rcx,1BDFF804A70
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M01_L31
M01_L15:
       mov       rcx,offset MT_System.Threading.Tasks.TaskReplicator+ReplicatableUserAction`1[[System.Threading.Tasks.RangeWorker, System.Threading.Tasks.Parallel]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFB8C1036A8
       mov       [rdi+18],rdx
       mov       rdx,[rbp-98]
       mov       rdx,[rdx+10]
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFB8C10C948]; System.Threading.Tasks.TaskReplicator.Run[[System.Threading.Tasks.RangeWorker, System.Threading.Tasks.Parallel]](ReplicatableUserAction`1<System.Threading.Tasks.RangeWorker>, System.Threading.Tasks.ParallelOptions, Boolean)
       nop
       mov       rdx,[rbp-98]
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-70],0
       je        short M01_L17
       lea       rcx,[rbp-68]
       call      qword ptr [7FFB8C1076F0]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdx+8]
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rdx,[rbp-98]
       cmp       qword ptr [rdx+8],0
       jne       short M01_L16
       jmp       short M01_L19
M01_L18:
       nop
       mov       rdx,[rbp-98]
M01_L19:
       mov       rcx,rsp
       call      M01_L34
       nop
       mov       r8,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rbp-58]
       vmovdqu   xmmword ptr [r8],xmm0
       mov       rax,[rbp-48]
       mov       [r8+10],rax
       movzx     eax,byte ptr [rbp-8C]
       mov       [r8],al
       mov       rax,r8
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       mov       rsi,rdi
       jmp       near ptr M01_L12
M01_L21:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       lea       rdx,[rbp-88]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFB8C1B41E0]
M01_L22:
       mov       rcx,[rbp-88]
       mov       rax,[rbp-80]
       mov       r8,[rbp-98]
       jmp       near ptr M01_L14
M01_L23:
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-70],rcx
       mov       rcx,offset MT_System.Action`1[[System.Object, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset System.Threading.Tasks.Parallel+<>c__DisplayClass19_0`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].<ForWorker>b__0(System.Object)
       mov       [rsi+18],rdx
       mov       rcx,[rbp-70]
       test      rcx,rcx
       jne       short M01_L21
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-88],xmm0
       jmp       short M01_L22
M01_L24:
       lea       rcx,[rbp-70]
       call      qword ptr [7FFB8BE95740]
       int       3
M01_L25:
       call      qword ptr [7FFB8C1071F8]
       mov       rcx,1BDFF800918
       test      rax,rax
       cmove     rax,[rcx]
       mov       rcx,rax
       mov       r8,[rbp-98]
       jmp       near ptr M01_L06
M01_L26:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       esi,eax
       mov       r8,[rbp-98]
       jmp       near ptr M01_L07
M01_L27:
       cmp       ebx,0FFFFFFFF
       je        short M01_L28
       cmp       esi,ebx
       cmovg     esi,ebx
       mov       ebx,esi
       jmp       short M01_L29
M01_L28:
       mov       ebx,esi
M01_L29:
       jmp       near ptr M01_L08
M01_L30:
       inc       ebx
       jmp       near ptr M01_L03
M01_L31:
       mov       rax,7FFB8C0FE540
       mov       ecx,1
       lock xadd [rax],ecx
       inc       ecx
       mov       r8,[rbp-98]
       mov       [r8+50],ecx
       mov       rax,1BDFF804A70
       mov       rbx,[rax]
       call      qword ptr [7FFB8C1071F8]
       mov       rcx,rax
       mov       rax,1BDFF800918
       test      rcx,rcx
       cmove     rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C107228]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       esi,eax
       call      qword ptr [7FFB8BE94420]
       mov       [rbp-78],rax
       mov       r8d,[rbp-74]
       mov       rax,[rbp-98]
       mov       r9d,[rax+50]
       movsxd    rcx,dword ptr [rbp+20]
       movsxd    rdx,dword ptr [rbp+28]
       mov       dword ptr [rsp+20],2
       mov       [rsp+28],rcx
       mov       [rsp+30],rdx
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFB8C10C798]
       jmp       near ptr M01_L15
M01_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0E0]
       mov       rax,[rbp-98]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-70],0
       je        short M01_L33
       lea       rcx,[rbp-68]
       call      qword ptr [7FFB8C1076F0]
M01_L33:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0E0]
       mov       rbx,rdx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C107990]
       mov       rsi,rax
       mov       rax,[rbp-98]
       mov       rcx,[rax+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C107090]; System.Threading.Tasks.ParallelOptions.get_CancellationToken()
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFB8C106328]
       lea       rax,[M01_L18]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L34:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0E0]
       mov       rdx,[rbp-98]
       mov       rax,[rdx+18]
       mov       esi,[rax+8]
       xor       eax,eax
       test      esi,esi
       sete      al
       mov       [rbp-8C],eax
       test      sil,2
       je        short M01_L35
       mov       rdx,[rbp-98]
       mov       rcx,[rdx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C107BA0]
       movsxd    rcx,eax
       mov       byte ptr [rbp-50],1
       mov       [rbp-48],rcx
M01_L35:
       mov       rax,1BDFF804A70
       mov       rax,[rax]
       cmp       byte ptr [rax+9D],0
       je        near ptr M01_L39
       test      esi,esi
       jne       short M01_L36
       mov       r9d,[rbp+28]
       mov       ebx,r9d
       sub       ebx,[rbp+20]
       jmp       short M01_L38
M01_L36:
       test      sil,2
       je        short M01_L37
       mov       rdx,[rbp-98]
       mov       rcx,[rdx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C107BA0]
       mov       ebx,eax
       sub       ebx,[rbp+20]
       jmp       short M01_L38
M01_L37:
       mov       ebx,0FFFFFFFF
M01_L38:
       mov       rax,1BDFF804A70
       mov       rsi,[rax]
       call      qword ptr [7FFB8C1071F8]
       mov       rcx,rax
       mov       rax,1BDFF800918
       test      rcx,rcx
       cmove     rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C107228]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       edi,eax
       call      qword ptr [7FFB8BE94420]
       mov       [rbp-78],rax
       mov       r8d,[rbp-74]
       mov       rax,[rbp-98]
       mov       r9d,[rax+50]
       movsxd    rcx,ebx
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FFB8C10C7B0]
M01_L39:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1971
```

## .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
```assembly
; BenchmarkLocks.LockingParallel.Parallel_UseInterLock()
;             Parallel.For(0, max_runs_per_invoke, (_) =>
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             {
;              
;                 UseInterLockSpin();
;                                    
;             });
;                
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+80]
       mov       rbx,rcx
       mov       rcx,offset MT_System.Action`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+18]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB8BED0D50
       mov       [rsi+18],rcx
       mov       rcx,1AED5C04A50
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       [rsp+28],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-30]
       mov       r9d,edi
       mov       rdx,offset MD_System.Threading.Tasks.Parallel.ForWorker[[System.Object, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.Object,System.Object>, System.Func`1<System.Object>, System.Action`1<System.Object>)
       xor       r8d,r8d
       call      qword ptr [7FFB8C0E64F0]; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 147
```
```assembly
; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       vzeroupper
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       [rbp-60],rax
       mov       [rbp-0A8],rsp
       mov       [rbp-40],rdx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L02
M01_L00:
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       [rbp-98],r8
       lea       rcx,[r8+10]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-98]
       lea       rcx,[r8+28]
       mov       rdx,[rbp+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-98]
       lea       rcx,[r8+30]
       mov       rdx,[rbp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-98]
       lea       rcx,[r8+38]
       mov       rdx,[rbp+50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-98]
       lea       rcx,[r8+40]
       mov       rdx,[rbp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-98]
       lea       rcx,[r8+48]
       mov       rdx,[rbp+58]
       call      CORINFO_HELP_ASSIGN_REF
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-58],xmm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       r9d,[rbp+28]
       cmp       r9d,[rbp+20]
       jle       short M01_L01
       mov       rcx,offset MT_System.Threading.Tasks.ParallelLoopStateFlags`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+0C],7FFFFFFF
       mov       r8,[rbp-98]
       lea       rcx,[r8+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-98]
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-70],0
       je        near ptr M01_L06
       mov       rcx,[rbp-70]
       cmp       dword ptr [rcx+20],0
       je        near ptr M01_L06
       jmp       near ptr M01_L22
M01_L01:
       mov       r8,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rbp-58]
       vmovdqu   xmmword ptr [r8],xmm0
       mov       rax,[rbp-48]
       mov       [r8+10],rax
       mov       byte ptr [r8],1
       mov       rax,r8
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       rcx,rdx
       mov       rdx,7FFB8C0F19F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L03:
       mov       ebx,14
M01_L04:
       movsxd    rsi,dword ptr [rbp+20]
       movsxd    rdi,dword ptr [rbp+28]
       mov       rcx,offset MT_System.Threading.Tasks.RangeManager
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       eax,eax
       mov       [r14+18],eax
       mov       qword ptr [r14+10],1
       mov       eax,2
       cmp       ebx,1
       cmove     ebx,eax
       mov       rcx,rdi
       sub       rcx,rsi
       movsxd    r8,ebx
       mov       rax,rcx
       xor       edx,edx
       div       r8
       mov       r8,rax
       mov       eax,1
       test      r8,r8
       cmove     r8,rax
       mov       rax,rcx
       xor       edx,edx
       div       r8
       mov       ebx,eax
       mov       rax,rcx
       xor       edx,edx
       div       r8
       lea       ecx,[rbx+1]
       test      rdx,rdx
       cmovne    ebx,ecx
       mov       r15,r8
       mov       byte ptr [r14+1C],0
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Threading.Tasks.IndexRange[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M01_L12
M01_L05:
       mov       rcx,[r14+8]
       cmp       r13d,[rcx+8]
       jae       near ptr M01_L29
       mov       edx,r13d
       shl       rdx,5
       lea       rcx,[rcx+rdx+10]
       mov       [rcx+8],rsi
       xor       eax,eax
       mov       [rcx],rax
       mov       rcx,[r14+8]
       cmp       r13d,[rcx+8]
       jae       near ptr M01_L29
       lea       r12,[rcx+rdx+10]
       mov       [r12+18],eax
       add       rsi,r15
       mov       rcx,rsi
       sub       rcx,r15
       cmp       rcx,rsi
       jg        short M01_L10
       cmp       rsi,rdi
       jle       short M01_L11
       jmp       short M01_L10
M01_L06:
       mov       rcx,[r8+10]
       mov       ebx,[rcx+10]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        near ptr M01_L23
M01_L07:
       mov       rax,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [rcx],rax
       jne       near ptr M01_L24
       mov       esi,7FFFFFFF
M01_L08:
       test      esi,esi
       jle       short M01_L09
       cmp       esi,7FFFFFFF
       jne       near ptr M01_L25
M01_L09:
       cmp       ebx,0FFFFFFFF
       je        near ptr M01_L03
       mov       rcx,[r8+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E70C0]; System.Threading.Tasks.ParallelOptions.get_EffectiveMaxConcurrencyLevel()
       mov       ebx,eax
       jmp       near ptr M01_L04
M01_L10:
       mov       rsi,rdi
M01_L11:
       mov       [r12+10],rsi
       inc       r13d
       cmp       r13d,ebx
       jl        near ptr M01_L05
M01_L12:
       mov       r8,[rbp-98]
       lea       rcx,[r8+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       r8,[rbp-98]
       mov       [r8+8],rcx
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-70],0
       jne       near ptr M01_L19
       xor       ecx,ecx
       xor       eax,eax
M01_L13:
       mov       [rbp-68],rcx
       mov       [rbp-60],rax
       xor       ecx,ecx
       mov       [r8+50],ecx
       mov       rcx,1AED5C04A70
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M01_L28
M01_L14:
       mov       rcx,offset MT_System.Threading.Tasks.TaskReplicator+ReplicatableUserAction`1[[System.Threading.Tasks.RangeWorker, System.Threading.Tasks.Parallel]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFB8C0E36A8
       mov       [rdi+18],rdx
       mov       rdx,[rbp-98]
       mov       rdx,[rdx+10]
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFB8C0EC948]; System.Threading.Tasks.TaskReplicator.Run[[System.Threading.Tasks.RangeWorker, System.Threading.Tasks.Parallel]](ReplicatableUserAction`1<System.Threading.Tasks.RangeWorker>, System.Threading.Tasks.ParallelOptions, Boolean)
       nop
       mov       rdx,[rbp-98]
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-70],0
       je        short M01_L16
       lea       rcx,[rbp-68]
       call      qword ptr [7FFB8C0E76F0]
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rdx+8]
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rdx,[rbp-98]
       cmp       qword ptr [rdx+8],0
       jne       short M01_L15
       jmp       short M01_L18
M01_L17:
       nop
       mov       rdx,[rbp-98]
M01_L18:
       mov       rcx,rsp
       call      M01_L31
       nop
       mov       r8,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rbp-58]
       vmovdqu   xmmword ptr [r8],xmm0
       mov       rax,[rbp-48]
       mov       [r8+10],rax
       movzx     eax,byte ptr [rbp-8C]
       mov       [r8],al
       mov       rax,r8
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-70],rcx
       mov       rcx,offset MT_System.Action`1[[System.Object, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset System.Threading.Tasks.Parallel+<>c__DisplayClass19_0`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].<ForWorker>b__0(System.Object)
       mov       [rbx+18],rdx
       mov       rcx,[rbp-70]
       test      rcx,rcx
       jne       short M01_L20
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-88],xmm0
       jmp       short M01_L21
M01_L20:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       lea       rdx,[rbp-88]
       mov       r8,rbx
       xor       r9d,r9d
       call      qword ptr [7FFB8C184D98]
M01_L21:
       mov       rcx,[rbp-88]
       mov       rax,[rbp-80]
       mov       r8,[rbp-98]
       jmp       near ptr M01_L13
M01_L22:
       lea       rcx,[rbp-70]
       call      qword ptr [7FFB8BE75740]
       int       3
M01_L23:
       call      qword ptr [7FFB8C0E71F8]
       mov       rcx,1AED5C00918
       test      rax,rax
       cmove     rax,[rcx]
       mov       rcx,rax
       mov       r8,[rbp-98]
       jmp       near ptr M01_L07
M01_L24:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       esi,eax
       mov       r8,[rbp-98]
       jmp       near ptr M01_L08
M01_L25:
       cmp       ebx,0FFFFFFFF
       je        short M01_L26
       cmp       esi,ebx
       cmovg     esi,ebx
       mov       ebx,esi
       jmp       short M01_L27
M01_L26:
       mov       ebx,esi
M01_L27:
       jmp       near ptr M01_L09
M01_L28:
       mov       rax,7FFB8C0DE540
       mov       ecx,1
       lock xadd [rax],ecx
       inc       ecx
       mov       r8,[rbp-98]
       mov       [r8+50],ecx
       mov       rax,1AED5C04A70
       mov       rbx,[rax]
       call      qword ptr [7FFB8C0E71F8]
       mov       rcx,rax
       mov       rax,1AED5C00918
       test      rcx,rcx
       cmove     rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7228]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       esi,eax
       call      qword ptr [7FFB8BE74420]
       mov       [rbp-78],rax
       mov       r8d,[rbp-74]
       mov       rax,[rbp-98]
       mov       r9d,[rax+50]
       movsxd    rcx,dword ptr [rbp+20]
       movsxd    rdx,dword ptr [rbp+28]
       mov       dword ptr [rsp+20],2
       mov       [rsp+28],rcx
       mov       [rsp+30],rdx
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFB8C0EC798]
       jmp       near ptr M01_L14
M01_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0E0]
       mov       rax,[rbp-98]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-70],0
       je        short M01_L30
       lea       rcx,[rbp-68]
       call      qword ptr [7FFB8C0E76F0]
M01_L30:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0E0]
       mov       rbx,rdx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7990]
       mov       rsi,rax
       mov       rax,[rbp-98]
       mov       rcx,[rax+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7090]; System.Threading.Tasks.ParallelOptions.get_CancellationToken()
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFB8C0E6328]
       lea       rax,[M01_L17]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L31:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0E0]
       mov       rdx,[rbp-98]
       mov       rax,[rdx+18]
       mov       ebx,[rax+8]
       xor       eax,eax
       test      ebx,ebx
       sete      al
       mov       [rbp-8C],eax
       test      bl,2
       je        short M01_L32
       mov       rdx,[rbp-98]
       mov       rcx,[rdx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7BA0]
       movsxd    rcx,eax
       mov       byte ptr [rbp-50],1
       mov       [rbp-48],rcx
M01_L32:
       mov       rax,1AED5C04A70
       mov       rax,[rax]
       cmp       byte ptr [rax+9D],0
       je        near ptr M01_L36
       test      ebx,ebx
       jne       short M01_L33
       mov       r9d,[rbp+28]
       mov       esi,r9d
       sub       esi,[rbp+20]
       jmp       short M01_L35
M01_L33:
       test      bl,2
       je        short M01_L34
       mov       rdx,[rbp-98]
       mov       rcx,[rdx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7BA0]
       mov       esi,eax
       sub       esi,[rbp+20]
       jmp       short M01_L35
M01_L34:
       mov       esi,0FFFFFFFF
M01_L35:
       mov       rax,1AED5C04A70
       mov       rbx,[rax]
       call      qword ptr [7FFB8C0E71F8]
       mov       rcx,rax
       mov       rax,1AED5C00918
       test      rcx,rcx
       cmove     rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7228]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       edi,eax
       call      qword ptr [7FFB8BE74420]
       mov       [rbp-78],rax
       mov       r8d,[rbp-74]
       mov       rax,[rbp-98]
       mov       r9d,[rax+50]
       movsxd    rcx,esi
       mov       [rsp+20],rcx
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFB8C0EC7B0]
M01_L36:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1945
```

## .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
```assembly
; BenchmarkLocks.LockingParallel.NoLock()
;             Parallel.For(0, max_runs_per_invoke, (_) =>
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             {
;              
;                 unchecked { value += 1; }
;                                          
;             });
;                
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+80]
       mov       rbx,rcx
       mov       rcx,offset MT_System.Action`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+18]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB8BED0D20
       mov       [rsi+18],rcx
       mov       rcx,20D32804A50
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       [rsp+28],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-30]
       mov       r9d,edi
       mov       rdx,offset MD_System.Threading.Tasks.Parallel.ForWorker[[System.Object, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.Object,System.Object>, System.Func`1<System.Object>, System.Action`1<System.Object>)
       xor       r8d,r8d
       call      qword ptr [7FFB8C0E64F0]; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 147
```
```assembly
; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-98],rsp
       mov       [rbp-38],rdx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L02
M01_L00:
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       [rbp-90],r8
       lea       rcx,[r8+10]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-90]
       lea       rcx,[r8+28]
       mov       rdx,[rbp+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-90]
       lea       rcx,[r8+30]
       mov       rdx,[rbp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-90]
       lea       rcx,[r8+38]
       mov       rdx,[rbp+50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-90]
       lea       rcx,[r8+40]
       mov       rdx,[rbp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-90]
       lea       rcx,[r8+48]
       mov       rdx,[rbp+58]
       call      CORINFO_HELP_ASSIGN_REF
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       r9d,[rbp+28]
       cmp       r9d,[rbp+20]
       jle       short M01_L01
       mov       rcx,offset MT_System.Threading.Tasks.ParallelLoopStateFlags`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+0C],7FFFFFFF
       mov       r8,[rbp-90]
       lea       rcx,[r8+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-90]
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-68],rcx
       cmp       qword ptr [rbp-68],0
       je        near ptr M01_L04
       mov       rcx,[rbp-68]
       cmp       dword ptr [rcx+20],0
       je        near ptr M01_L04
       jmp       near ptr M01_L23
M01_L01:
       mov       r8,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [r8],xmm0
       mov       rax,[rbp-40]
       mov       [r8+10],rax
       mov       byte ptr [r8],1
       mov       rax,r8
       add       rsp,0A0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       rcx,rdx
       mov       rdx,7FFB8C0F19F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L03:
       mov       r15,r8
       mov       byte ptr [r14+1C],0
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Threading.Tasks.IndexRange[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M01_L12
       jmp       near ptr M01_L10
M01_L04:
       mov       rcx,[r8+10]
       mov       ebx,[rcx+10]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        near ptr M01_L24
M01_L05:
       mov       rax,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [rcx],rax
       jne       near ptr M01_L25
       mov       esi,7FFFFFFF
M01_L06:
       test      esi,esi
       jle       short M01_L07
       cmp       esi,7FFFFFFF
       jne       near ptr M01_L26
M01_L07:
       cmp       ebx,0FFFFFFFF
       jne       short M01_L09
       mov       ebx,14
M01_L08:
       movsxd    rsi,dword ptr [rbp+20]
       movsxd    rdi,dword ptr [rbp+28]
       mov       rcx,offset MT_System.Threading.Tasks.RangeManager
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       eax,eax
       mov       [r14+18],eax
       mov       qword ptr [r14+10],1
       mov       eax,2
       cmp       ebx,1
       cmove     ebx,eax
       mov       rcx,rdi
       sub       rcx,rsi
       movsxd    r8,ebx
       mov       rax,rcx
       xor       edx,edx
       div       r8
       mov       r8,rax
       mov       eax,1
       test      r8,r8
       cmove     r8,rax
       mov       rax,rcx
       xor       edx,edx
       div       r8
       mov       ebx,eax
       mov       rax,rcx
       xor       edx,edx
       div       r8
       test      rdx,rdx
       jne       near ptr M01_L29
       jmp       near ptr M01_L03
M01_L09:
       mov       rcx,[r8+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E70C0]; System.Threading.Tasks.ParallelOptions.get_EffectiveMaxConcurrencyLevel()
       mov       ebx,eax
       jmp       near ptr M01_L08
M01_L10:
       mov       rax,[r14+8]
       cmp       r13d,[rax+8]
       jae       near ptr M01_L31
       mov       ecx,r13d
       shl       rcx,5
       lea       rax,[rax+rcx+10]
       mov       [rax+8],rsi
       xor       r8d,r8d
       mov       [rax],r8
       mov       rax,[r14+8]
       cmp       r13d,[rax+8]
       jae       near ptr M01_L31
       lea       rax,[rax+rcx+10]
       mov       [rax+18],r8d
       add       rsi,r15
       mov       rcx,rsi
       sub       rcx,r15
       cmp       rcx,rsi
       jg        near ptr M01_L19
       cmp       rsi,rdi
       jg        near ptr M01_L19
M01_L11:
       mov       [rax+10],rsi
       inc       r13d
       cmp       r13d,ebx
       jl        short M01_L10
M01_L12:
       mov       r8,[rbp-90]
       lea       rcx,[r8+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       r8,[rbp-90]
       mov       [r8+8],rcx
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-68],rcx
       cmp       qword ptr [rbp-68],0
       jne       near ptr M01_L22
       xor       ecx,ecx
       xor       eax,eax
M01_L13:
       mov       [rbp-60],rcx
       mov       [rbp-58],rax
       xor       ecx,ecx
       mov       [r8+50],ecx
       mov       rcx,20D32804A70
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M01_L30
M01_L14:
       mov       rcx,offset MT_System.Threading.Tasks.TaskReplicator+ReplicatableUserAction`1[[System.Threading.Tasks.RangeWorker, System.Threading.Tasks.Parallel]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFB8C0E36A8
       mov       [r13+18],rdx
       mov       rdx,[rbp-90]
       mov       rdx,[rdx+10]
       mov       rcx,r13
       mov       r8d,1
       call      qword ptr [7FFB8C0EC948]; System.Threading.Tasks.TaskReplicator.Run[[System.Threading.Tasks.RangeWorker, System.Threading.Tasks.Parallel]](ReplicatableUserAction`1<System.Threading.Tasks.RangeWorker>, System.Threading.Tasks.ParallelOptions, Boolean)
       nop
       mov       rdx,[rbp-90]
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-68],rcx
       cmp       qword ptr [rbp-68],0
       je        short M01_L16
       lea       rcx,[rbp-60]
       call      qword ptr [7FFB8C0E76F0]
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rdx+8]
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rdx,[rbp-90]
       cmp       qword ptr [rdx+8],0
       jne       short M01_L15
       jmp       short M01_L18
M01_L17:
       nop
       mov       rdx,[rbp-90]
M01_L18:
       mov       rcx,rsp
       call      M01_L33
       nop
       mov       r8,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [r8],xmm0
       mov       rax,[rbp-40]
       mov       [r8+10],rax
       movzx     eax,byte ptr [rbp-84]
       mov       [r8],al
       mov       rax,r8
       add       rsp,0A0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       rsi,rdi
       jmp       near ptr M01_L11
M01_L20:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       lea       rdx,[rbp-80]
       mov       r8,r14
       xor       r9d,r9d
       call      qword ptr [7FFB8C184D98]
M01_L21:
       mov       rcx,[rbp-80]
       mov       rax,[rbp-78]
       mov       r8,[rbp-90]
       jmp       near ptr M01_L13
M01_L22:
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-68],rcx
       mov       rcx,offset MT_System.Action`1[[System.Object, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset System.Threading.Tasks.Parallel+<>c__DisplayClass19_0`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].<ForWorker>b__0(System.Object)
       mov       [r14+18],rdx
       mov       rcx,[rbp-68]
       test      rcx,rcx
       jne       short M01_L20
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-80],xmm0
       jmp       short M01_L21
M01_L23:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFB8BE75740]
       int       3
M01_L24:
       call      qword ptr [7FFB8C0E71F8]
       mov       rcx,20D32800918
       test      rax,rax
       cmove     rax,[rcx]
       mov       rcx,rax
       mov       r8,[rbp-90]
       jmp       near ptr M01_L05
M01_L25:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       esi,eax
       mov       r8,[rbp-90]
       jmp       near ptr M01_L06
M01_L26:
       cmp       ebx,0FFFFFFFF
       je        short M01_L27
       cmp       esi,ebx
       cmovg     esi,ebx
       mov       ebx,esi
       jmp       short M01_L28
M01_L27:
       mov       ebx,esi
M01_L28:
       jmp       near ptr M01_L07
M01_L29:
       inc       ebx
       jmp       near ptr M01_L03
M01_L30:
       mov       rax,7FFB8C0DE540
       mov       ecx,1
       lock xadd [rax],ecx
       inc       ecx
       mov       r8,[rbp-90]
       mov       [r8+50],ecx
       mov       rax,20D32804A70
       mov       rbx,[rax]
       call      qword ptr [7FFB8C0E71F8]
       mov       rcx,rax
       mov       rax,20D32800918
       test      rcx,rcx
       cmove     rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7228]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       esi,eax
       call      qword ptr [7FFB8BE74420]
       mov       [rbp-70],rax
       mov       r8d,[rbp-6C]
       mov       rax,[rbp-90]
       mov       r9d,[rax+50]
       movsxd    rcx,dword ptr [rbp+20]
       movsxd    rdx,dword ptr [rbp+28]
       mov       dword ptr [rsp+20],2
       mov       [rsp+28],rcx
       mov       [rsp+30],rdx
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFB8C0EC798]
       jmp       near ptr M01_L14
M01_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0D0]
       mov       rax,[rbp-90]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       mov       [rbp-68],rcx
       cmp       qword ptr [rbp-68],0
       je        short M01_L32
       lea       rcx,[rbp-60]
       call      qword ptr [7FFB8C0E76F0]
M01_L32:
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0D0]
       mov       rbx,rdx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7990]
       mov       rsi,rax
       mov       rax,[rbp-90]
       mov       rcx,[rax+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7090]; System.Threading.Tasks.ParallelOptions.get_CancellationToken()
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFB8C0E6328]
       lea       rax,[M01_L17]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L33:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0D0]
       mov       rdx,[rbp-90]
       mov       rax,[rdx+18]
       mov       esi,[rax+8]
       xor       eax,eax
       test      esi,esi
       sete      al
       mov       [rbp-84],eax
       test      sil,2
       je        short M01_L34
       mov       rdx,[rbp-90]
       mov       rcx,[rdx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7BA0]
       movsxd    rcx,eax
       mov       byte ptr [rbp-48],1
       mov       [rbp-40],rcx
M01_L34:
       mov       rax,20D32804A70
       mov       rax,[rax]
       cmp       byte ptr [rax+9D],0
       je        near ptr M01_L38
       test      esi,esi
       jne       short M01_L35
       mov       r9d,[rbp+28]
       mov       ebx,r9d
       sub       ebx,[rbp+20]
       jmp       short M01_L37
M01_L35:
       test      sil,2
       je        short M01_L36
       mov       rdx,[rbp-90]
       mov       rcx,[rdx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7BA0]
       mov       ebx,eax
       sub       ebx,[rbp+20]
       jmp       short M01_L37
M01_L36:
       mov       ebx,0FFFFFFFF
M01_L37:
       mov       rax,20D32804A70
       mov       rsi,[rax]
       call      qword ptr [7FFB8C0E71F8]
       mov       rcx,rax
       mov       rax,20D32800918
       test      rcx,rcx
       cmove     rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7228]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       edi,eax
       call      qword ptr [7FFB8BE74420]
       mov       [rbp-70],rax
       mov       r8d,[rbp-6C]
       mov       rax,[rbp-90]
       mov       r9d,[rax+50]
       movsxd    rcx,ebx
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FFB8C0EC7B0]
M01_L38:
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1931
```

## .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
```assembly
; BenchmarkLocks.LockingParallel.Parallel_UseLock()
;             Parallel.For(0, max_runs_per_invoke, (_) =>
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             {
;              
;                 UseLock();
;                           
;             });
;                
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+80]
       mov       rbx,rcx
       mov       rcx,offset MT_System.Action`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+18]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB8BF00D38
       mov       [rsi+18],rcx
       mov       rcx,27C2B804A50
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       [rsp+28],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-30]
       mov       r9d,edi
       mov       rdx,offset MD_System.Threading.Tasks.Parallel.ForWorker[[System.Object, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.Object,System.Object>, System.Func`1<System.Object>, System.Action`1<System.Object>)
       xor       r8d,r8d
       call      qword ptr [7FFB8C116598]; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 147
```
```assembly
; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       vzeroupper
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       [rbp-98],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L02
M01_L00:
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       [rbp-88],r8
       lea       rcx,[r8+10]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       lea       rcx,[r8+28]
       mov       rdx,[rbp+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       lea       rcx,[r8+30]
       mov       rdx,[rbp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       lea       rcx,[r8+38]
       mov       rdx,[rbp+50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       lea       rcx,[r8+40]
       mov       rdx,[rbp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       lea       rcx,[r8+48]
       mov       rdx,[rbp+58]
       call      CORINFO_HELP_ASSIGN_REF
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       vmovdqu   xmmword ptr [rbp-40],xmm0
       mov       r9d,[rbp+28]
       cmp       r9d,[rbp+20]
       jle       short M01_L01
       mov       rcx,offset MT_System.Threading.Tasks.ParallelLoopStateFlags`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+0C],7FFFFFFF
       mov       r8,[rbp-88]
       lea       rcx,[r8+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       cmp       qword ptr [rbp-60],0
       je        near ptr M01_L11
       mov       rcx,[rbp-60]
       cmp       dword ptr [rcx+20],0
       je        near ptr M01_L11
       jmp       near ptr M01_L24
M01_L01:
       mov       r8,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [r8],xmm0
       mov       rax,[rbp-38]
       mov       [r8+10],rax
       mov       byte ptr [r8],1
       mov       rax,r8
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       rcx,rdx
       mov       rdx,7FFB8C1219F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L03:
       mov       ebx,14
M01_L04:
       movsxd    rsi,dword ptr [rbp+20]
       movsxd    rdi,dword ptr [rbp+28]
       mov       rcx,offset MT_System.Threading.Tasks.RangeManager
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       eax,eax
       mov       [r14+18],eax
       mov       qword ptr [r14+10],1
       mov       eax,2
       cmp       ebx,1
       cmove     ebx,eax
       mov       rcx,rdi
       sub       rcx,rsi
       movsxd    r8,ebx
       mov       rax,rcx
       xor       edx,edx
       div       r8
       mov       r8,rax
       mov       eax,1
       test      r8,r8
       cmove     r8,rax
       mov       rax,rcx
       xor       edx,edx
       div       r8
       mov       ebx,eax
       mov       rax,rcx
       xor       edx,edx
       div       r8
       lea       ecx,[rbx+1]
       test      rdx,rdx
       cmovne    ebx,ecx
       mov       r15,r8
       mov       byte ptr [r14+1C],0
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Threading.Tasks.IndexRange[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       test      ebx,ebx
       jle       short M01_L07
M01_L05:
       mov       rdx,[r14+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M01_L30
       mov       eax,ecx
       shl       rax,5
       lea       rdx,[rdx+rax+10]
       mov       [rdx+8],rsi
       xor       r8d,r8d
       mov       [rdx],r8
       mov       rdx,[r14+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M01_L30
       lea       rdx,[rdx+rax+10]
       mov       [rdx+18],r8d
       add       rsi,r15
       mov       rax,rsi
       sub       rax,r15
       cmp       rax,rsi
       jg        near ptr M01_L10
       cmp       rsi,rdi
       jg        near ptr M01_L10
M01_L06:
       mov       [rdx+10],rsi
       inc       ecx
       cmp       ecx,ebx
       jl        short M01_L05
M01_L07:
       mov       r8,[rbp-88]
       lea       rcx,[r8+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       r8,[rbp-88]
       mov       [r8+8],rcx
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       cmp       qword ptr [rbp-60],0
       jne       short M01_L09
       xor       ecx,ecx
       xor       eax,eax
M01_L08:
       mov       [rbp-58],rcx
       mov       [rbp-50],rax
       xor       ecx,ecx
       mov       [r8+50],ecx
       mov       rcx,27C2B804A70
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M01_L18
       jmp       near ptr M01_L19
M01_L09:
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       mov       rcx,offset MT_System.Action`1[[System.Object, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp-88]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset System.Threading.Tasks.Parallel+<>c__DisplayClass19_0`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].<ForWorker>b__0(System.Object)
       mov       [rbx+18],rdx
       mov       rcx,[rbp-60]
       test      rcx,rcx
       jne       short M01_L15
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-78],xmm0
       jmp       short M01_L16
M01_L10:
       mov       rsi,rdi
       jmp       near ptr M01_L06
M01_L11:
       mov       rcx,[r8+10]
       mov       ebx,[rcx+10]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        near ptr M01_L25
M01_L12:
       mov       rax,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [rcx],rax
       jne       near ptr M01_L26
       mov       esi,7FFFFFFF
M01_L13:
       test      esi,esi
       jle       short M01_L14
       cmp       esi,7FFFFFFF
       jne       near ptr M01_L27
M01_L14:
       cmp       ebx,0FFFFFFFF
       je        near ptr M01_L03
       mov       rcx,[r8+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C117168]; System.Threading.Tasks.ParallelOptions.get_EffectiveMaxConcurrencyLevel()
       mov       ebx,eax
       jmp       near ptr M01_L04
M01_L15:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       lea       rdx,[rbp-78]
       mov       r8,rbx
       xor       r9d,r9d
       call      qword ptr [7FFB8C1C41E0]
M01_L16:
       mov       rcx,[rbp-78]
       mov       rax,[rbp-70]
       mov       r8,[rbp-88]
       jmp       near ptr M01_L08
M01_L17:
       mov       rcx,rsp
       call      M01_L32
       nop
       mov       r8,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [r8],xmm0
       mov       rax,[rbp-38]
       mov       [r8+10],rax
       movzx     eax,byte ptr [rbp-7C]
       mov       [r8],al
       mov       rax,r8
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       mov       rax,7FFB8C10E350
       mov       ecx,1
       lock xadd [rax],ecx
       inc       ecx
       mov       r8,[rbp-88]
       mov       [r8+50],ecx
       mov       rax,27C2B804A70
       mov       rbx,[rax]
       call      qword ptr [7FFB8C1172A0]
       mov       rcx,rax
       mov       rax,27C2B800918
       test      rcx,rcx
       cmove     rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C1172D0]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       esi,eax
       call      qword ptr [7FFB8BEA4420]
       mov       [rbp-68],rax
       mov       r8d,[rbp-64]
       mov       rax,[rbp-88]
       mov       r9d,[rax+50]
       movsxd    rcx,dword ptr [rbp+20]
       movsxd    rdx,dword ptr [rbp+28]
       mov       dword ptr [rsp+20],2
       mov       [rsp+28],rcx
       mov       [rsp+30],rdx
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFB8C11C798]
       nop
M01_L19:
       jmp       short M01_L21
M01_L20:
       mov       rcx,[rdx+8]
       call      CORINFO_HELP_THROW
       int       3
M01_L21:
       mov       rcx,offset MT_System.Threading.Tasks.TaskReplicator+ReplicatableUserAction`1[[System.Threading.Tasks.RangeWorker, System.Threading.Tasks.Parallel]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp-88]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFB8C113750
       mov       [rbx+18],rdx
       mov       rdx,[rbp-88]
       mov       rdx,[rdx+10]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFB8C11C948]; System.Threading.Tasks.TaskReplicator.Run[[System.Threading.Tasks.RangeWorker, System.Threading.Tasks.Parallel]](ReplicatableUserAction`1<System.Threading.Tasks.RangeWorker>, System.Threading.Tasks.ParallelOptions, Boolean)
       nop
       mov       rdx,[rbp-88]
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       cmp       qword ptr [rbp-60],0
       je        short M01_L22
       lea       rcx,[rbp-58]
       call      qword ptr [7FFB8C117798]
M01_L22:
       mov       rdx,[rbp-88]
       cmp       qword ptr [rdx+8],0
       jne       near ptr M01_L20
       jmp       near ptr M01_L17
M01_L23:
       nop
       mov       rdx,[rbp-88]
       jmp       near ptr M01_L17
M01_L24:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFB8BEA5740]
       int       3
M01_L25:
       call      qword ptr [7FFB8C1172A0]
       mov       rcx,27C2B800918
       test      rax,rax
       cmove     rax,[rcx]
       mov       rcx,rax
       mov       r8,[rbp-88]
       jmp       near ptr M01_L12
M01_L26:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       esi,eax
       mov       r8,[rbp-88]
       jmp       near ptr M01_L13
M01_L27:
       cmp       ebx,0FFFFFFFF
       je        short M01_L28
       cmp       esi,ebx
       cmovg     esi,ebx
       mov       ebx,esi
       jmp       short M01_L29
M01_L28:
       mov       ebx,esi
M01_L29:
       jmp       near ptr M01_L14
M01_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0D0]
       mov       rax,[rbp-88]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       cmp       qword ptr [rbp-60],0
       je        short M01_L31
       lea       rcx,[rbp-58]
       call      qword ptr [7FFB8C117798]
M01_L31:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0D0]
       mov       rbx,rdx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C117A38]
       mov       rsi,rax
       mov       rax,[rbp-88]
       mov       rcx,[rax+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C117138]; System.Threading.Tasks.ParallelOptions.get_CancellationToken()
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFB8C1163D0]
       lea       rax,[M01_L23]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L32:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0D0]
       mov       rdx,[rbp-88]
       mov       rax,[rdx+18]
       mov       ebx,[rax+8]
       xor       eax,eax
       test      ebx,ebx
       sete      al
       mov       [rbp-7C],eax
       test      bl,2
       je        short M01_L33
       mov       rdx,[rbp-88]
       mov       rcx,[rdx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C117C48]
       movsxd    rcx,eax
       mov       byte ptr [rbp-40],1
       mov       [rbp-38],rcx
M01_L33:
       mov       rax,27C2B804A70
       mov       rax,[rax]
       cmp       byte ptr [rax+9D],0
       je        near ptr M01_L37
       test      ebx,ebx
       jne       short M01_L34
       mov       r9d,[rbp+28]
       mov       esi,r9d
       sub       esi,[rbp+20]
       jmp       short M01_L36
M01_L34:
       test      bl,2
       je        short M01_L35
       mov       rdx,[rbp-88]
       mov       rcx,[rdx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C117C48]
       mov       esi,eax
       sub       esi,[rbp+20]
       jmp       short M01_L36
M01_L35:
       mov       esi,0FFFFFFFF
M01_L36:
       mov       rax,27C2B804A70
       mov       rbx,[rax]
       call      qword ptr [7FFB8C1172A0]
       mov       rcx,rax
       mov       rax,27C2B800918
       test      rcx,rcx
       cmove     rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C1172D0]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       edi,eax
       call      qword ptr [7FFB8BEA4420]
       mov       [rbp-68],rax
       mov       r8d,[rbp-64]
       mov       rax,[rbp-88]
       mov       r9d,[rax+50]
       movsxd    rcx,esi
       mov       [rsp+20],rcx
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFB8C11C7B0]
M01_L37:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1897
```

## .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
```assembly
; BenchmarkLocks.LockingParallel.Parallel_UseInterLock()
;             Parallel.For(0, max_runs_per_invoke, (_) =>
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             {
;              
;                 UseInterLockSpin();
;                                    
;             });
;                
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+80]
       mov       rbx,rcx
       mov       rcx,offset MT_System.Action`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+18]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB8BED0D50
       mov       [rsi+18],rcx
       mov       rcx,2C0A9404A50
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       [rsp+28],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-30]
       mov       r9d,edi
       mov       rdx,offset MD_System.Threading.Tasks.Parallel.ForWorker[[System.Object, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.Object,System.Object>, System.Func`1<System.Object>, System.Action`1<System.Object>)
       xor       r8d,r8d
       call      qword ptr [7FFB8C0E64F0]; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 147
```
```assembly
; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       vzeroupper
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       [rbp-60],rax
       mov       [rbp-0A8],rsp
       mov       [rbp-40],rdx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L02
M01_L00:
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       [rbp-98],r8
       lea       rcx,[r8+10]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-98]
       lea       rcx,[r8+28]
       mov       rdx,[rbp+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-98]
       lea       rcx,[r8+30]
       mov       rdx,[rbp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-98]
       lea       rcx,[r8+38]
       mov       rdx,[rbp+50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-98]
       lea       rcx,[r8+40]
       mov       rdx,[rbp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-98]
       lea       rcx,[r8+48]
       mov       rdx,[rbp+58]
       call      CORINFO_HELP_ASSIGN_REF
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-58],xmm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       r9d,[rbp+28]
       cmp       r9d,[rbp+20]
       jle       short M01_L01
       mov       rcx,offset MT_System.Threading.Tasks.ParallelLoopStateFlags`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+0C],7FFFFFFF
       mov       r8,[rbp-98]
       lea       rcx,[r8+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-98]
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-70],0
       je        near ptr M01_L06
       mov       rcx,[rbp-70]
       cmp       dword ptr [rcx+20],0
       je        near ptr M01_L06
       jmp       near ptr M01_L22
M01_L01:
       mov       r8,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rbp-58]
       vmovdqu   xmmword ptr [r8],xmm0
       mov       rax,[rbp-48]
       mov       [r8+10],rax
       mov       byte ptr [r8],1
       mov       rax,r8
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       rcx,rdx
       mov       rdx,7FFB8C0F19F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L03:
       mov       ebx,14
M01_L04:
       movsxd    rsi,dword ptr [rbp+20]
       movsxd    rdi,dword ptr [rbp+28]
       mov       rcx,offset MT_System.Threading.Tasks.RangeManager
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       eax,eax
       mov       [r14+18],eax
       mov       qword ptr [r14+10],1
       mov       eax,2
       cmp       ebx,1
       cmove     ebx,eax
       mov       rcx,rdi
       sub       rcx,rsi
       movsxd    r8,ebx
       mov       rax,rcx
       xor       edx,edx
       div       r8
       mov       r8,rax
       mov       eax,1
       test      r8,r8
       cmove     r8,rax
       mov       rax,rcx
       xor       edx,edx
       div       r8
       mov       ebx,eax
       mov       rax,rcx
       xor       edx,edx
       div       r8
       lea       ecx,[rbx+1]
       test      rdx,rdx
       cmovne    ebx,ecx
       mov       r15,r8
       mov       byte ptr [r14+1C],0
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Threading.Tasks.IndexRange[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M01_L12
M01_L05:
       mov       rcx,[r14+8]
       cmp       r13d,[rcx+8]
       jae       near ptr M01_L29
       mov       edx,r13d
       shl       rdx,5
       lea       rcx,[rcx+rdx+10]
       mov       [rcx+8],rsi
       xor       eax,eax
       mov       [rcx],rax
       mov       rcx,[r14+8]
       cmp       r13d,[rcx+8]
       jae       near ptr M01_L29
       lea       r12,[rcx+rdx+10]
       mov       [r12+18],eax
       add       rsi,r15
       mov       rcx,rsi
       sub       rcx,r15
       cmp       rcx,rsi
       jg        short M01_L10
       cmp       rsi,rdi
       jle       short M01_L11
       jmp       short M01_L10
M01_L06:
       mov       rcx,[r8+10]
       mov       ebx,[rcx+10]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        near ptr M01_L23
M01_L07:
       mov       rax,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [rcx],rax
       jne       near ptr M01_L24
       mov       esi,7FFFFFFF
M01_L08:
       test      esi,esi
       jle       short M01_L09
       cmp       esi,7FFFFFFF
       jne       near ptr M01_L25
M01_L09:
       cmp       ebx,0FFFFFFFF
       je        near ptr M01_L03
       mov       rcx,[r8+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E70C0]; System.Threading.Tasks.ParallelOptions.get_EffectiveMaxConcurrencyLevel()
       mov       ebx,eax
       jmp       near ptr M01_L04
M01_L10:
       mov       rsi,rdi
M01_L11:
       mov       [r12+10],rsi
       inc       r13d
       cmp       r13d,ebx
       jl        near ptr M01_L05
M01_L12:
       mov       r8,[rbp-98]
       lea       rcx,[r8+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       r8,[rbp-98]
       mov       [r8+8],rcx
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-70],0
       jne       near ptr M01_L19
       xor       ecx,ecx
       xor       eax,eax
M01_L13:
       mov       [rbp-68],rcx
       mov       [rbp-60],rax
       xor       ecx,ecx
       mov       [r8+50],ecx
       mov       rcx,2C0A9404A70
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M01_L28
M01_L14:
       mov       rcx,offset MT_System.Threading.Tasks.TaskReplicator+ReplicatableUserAction`1[[System.Threading.Tasks.RangeWorker, System.Threading.Tasks.Parallel]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFB8C0E36A8
       mov       [rdi+18],rdx
       mov       rdx,[rbp-98]
       mov       rdx,[rdx+10]
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFB8C0EC948]; System.Threading.Tasks.TaskReplicator.Run[[System.Threading.Tasks.RangeWorker, System.Threading.Tasks.Parallel]](ReplicatableUserAction`1<System.Threading.Tasks.RangeWorker>, System.Threading.Tasks.ParallelOptions, Boolean)
       nop
       mov       rdx,[rbp-98]
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-70],0
       je        short M01_L16
       lea       rcx,[rbp-68]
       call      qword ptr [7FFB8C0E76F0]
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rdx+8]
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rdx,[rbp-98]
       cmp       qword ptr [rdx+8],0
       jne       short M01_L15
       jmp       short M01_L18
M01_L17:
       nop
       mov       rdx,[rbp-98]
M01_L18:
       mov       rcx,rsp
       call      M01_L31
       nop
       mov       r8,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rbp-58]
       vmovdqu   xmmword ptr [r8],xmm0
       mov       rax,[rbp-48]
       mov       [r8+10],rax
       movzx     eax,byte ptr [rbp-8C]
       mov       [r8],al
       mov       rax,r8
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-70],rcx
       mov       rcx,offset MT_System.Action`1[[System.Object, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset System.Threading.Tasks.Parallel+<>c__DisplayClass19_0`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].<ForWorker>b__0(System.Object)
       mov       [rbx+18],rdx
       mov       rcx,[rbp-70]
       test      rcx,rcx
       jne       short M01_L20
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-88],xmm0
       jmp       short M01_L21
M01_L20:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       lea       rdx,[rbp-88]
       mov       r8,rbx
       xor       r9d,r9d
       call      qword ptr [7FFB8C184D98]
M01_L21:
       mov       rcx,[rbp-88]
       mov       rax,[rbp-80]
       mov       r8,[rbp-98]
       jmp       near ptr M01_L13
M01_L22:
       lea       rcx,[rbp-70]
       call      qword ptr [7FFB8BE75740]
       int       3
M01_L23:
       call      qword ptr [7FFB8C0E71F8]
       mov       rcx,2C0A9400918
       test      rax,rax
       cmove     rax,[rcx]
       mov       rcx,rax
       mov       r8,[rbp-98]
       jmp       near ptr M01_L07
M01_L24:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       esi,eax
       mov       r8,[rbp-98]
       jmp       near ptr M01_L08
M01_L25:
       cmp       ebx,0FFFFFFFF
       je        short M01_L26
       cmp       esi,ebx
       cmovg     esi,ebx
       mov       ebx,esi
       jmp       short M01_L27
M01_L26:
       mov       ebx,esi
M01_L27:
       jmp       near ptr M01_L09
M01_L28:
       mov       rax,7FFB8C0DE540
       mov       ecx,1
       lock xadd [rax],ecx
       inc       ecx
       mov       r8,[rbp-98]
       mov       [r8+50],ecx
       mov       rax,2C0A9404A70
       mov       rbx,[rax]
       call      qword ptr [7FFB8C0E71F8]
       mov       rcx,rax
       mov       rax,2C0A9400918
       test      rcx,rcx
       cmove     rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7228]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       esi,eax
       call      qword ptr [7FFB8BE74420]
       mov       [rbp-78],rax
       mov       r8d,[rbp-74]
       mov       rax,[rbp-98]
       mov       r9d,[rax+50]
       movsxd    rcx,dword ptr [rbp+20]
       movsxd    rdx,dword ptr [rbp+28]
       mov       dword ptr [rsp+20],2
       mov       [rsp+28],rcx
       mov       [rsp+30],rdx
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFB8C0EC798]
       jmp       near ptr M01_L14
M01_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0E0]
       mov       rax,[rbp-98]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-70],0
       je        short M01_L30
       lea       rcx,[rbp-68]
       call      qword ptr [7FFB8C0E76F0]
M01_L30:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0E0]
       mov       rbx,rdx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7990]
       mov       rsi,rax
       mov       rax,[rbp-98]
       mov       rcx,[rax+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7090]; System.Threading.Tasks.ParallelOptions.get_CancellationToken()
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFB8C0E6328]
       lea       rax,[M01_L17]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L31:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0E0]
       mov       rdx,[rbp-98]
       mov       rax,[rdx+18]
       mov       ebx,[rax+8]
       xor       eax,eax
       test      ebx,ebx
       sete      al
       mov       [rbp-8C],eax
       test      bl,2
       je        short M01_L32
       mov       rdx,[rbp-98]
       mov       rcx,[rdx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7BA0]
       movsxd    rcx,eax
       mov       byte ptr [rbp-50],1
       mov       [rbp-48],rcx
M01_L32:
       mov       rax,2C0A9404A70
       mov       rax,[rax]
       cmp       byte ptr [rax+9D],0
       je        near ptr M01_L36
       test      ebx,ebx
       jne       short M01_L33
       mov       r9d,[rbp+28]
       mov       esi,r9d
       sub       esi,[rbp+20]
       jmp       short M01_L35
M01_L33:
       test      bl,2
       je        short M01_L34
       mov       rdx,[rbp-98]
       mov       rcx,[rdx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7BA0]
       mov       esi,eax
       sub       esi,[rbp+20]
       jmp       short M01_L35
M01_L34:
       mov       esi,0FFFFFFFF
M01_L35:
       mov       rax,2C0A9404A70
       mov       rbx,[rax]
       call      qword ptr [7FFB8C0E71F8]
       mov       rcx,rax
       mov       rax,2C0A9400918
       test      rcx,rcx
       cmove     rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7228]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       edi,eax
       call      qword ptr [7FFB8BE74420]
       mov       [rbp-78],rax
       mov       r8d,[rbp-74]
       mov       rax,[rbp-98]
       mov       r9d,[rax+50]
       movsxd    rcx,esi
       mov       [rsp+20],rcx
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFB8C0EC7B0]
M01_L36:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1945
```

## .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
```assembly
; BenchmarkLocks.LockingParallel.NoLock()
;             Parallel.For(0, max_runs_per_invoke, (_) =>
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             {
;              
;                 unchecked { value += 1; }
;                                          
;             });
;                
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+80]
       mov       rbx,rcx
       mov       rcx,offset MT_System.Action`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+18]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB8BED0D20
       mov       [rsi+18],rcx
       mov       rcx,2BAD6C04A50
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       [rsp+28],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-30]
       mov       r9d,edi
       mov       rdx,offset MD_System.Threading.Tasks.Parallel.ForWorker[[System.Object, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.Object,System.Object>, System.Func`1<System.Object>, System.Action`1<System.Object>)
       xor       r8d,r8d
       call      qword ptr [7FFB8C0E64F0]; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 147
```
```assembly
; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       vzeroupper
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       [rbp-98],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L02
M01_L00:
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       [rbp-88],r8
       lea       rcx,[r8+10]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       lea       rcx,[r8+28]
       mov       rdx,[rbp+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       lea       rcx,[r8+30]
       mov       rdx,[rbp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       lea       rcx,[r8+38]
       mov       rdx,[rbp+50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       lea       rcx,[r8+40]
       mov       rdx,[rbp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       lea       rcx,[r8+48]
       mov       rdx,[rbp+58]
       call      CORINFO_HELP_ASSIGN_REF
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       vmovdqu   xmmword ptr [rbp-40],xmm0
       mov       r9d,[rbp+28]
       cmp       r9d,[rbp+20]
       jle       short M01_L01
       mov       rcx,offset MT_System.Threading.Tasks.ParallelLoopStateFlags`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+0C],7FFFFFFF
       mov       r8,[rbp-88]
       lea       rcx,[r8+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       cmp       qword ptr [rbp-60],0
       je        near ptr M01_L11
       mov       rcx,[rbp-60]
       cmp       dword ptr [rcx+20],0
       je        near ptr M01_L11
       jmp       near ptr M01_L24
M01_L01:
       mov       r8,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [r8],xmm0
       mov       rax,[rbp-38]
       mov       [r8+10],rax
       mov       byte ptr [r8],1
       mov       rax,r8
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       rcx,rdx
       mov       rdx,7FFB8C0F19F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L03:
       mov       ebx,14
M01_L04:
       movsxd    rsi,dword ptr [rbp+20]
       movsxd    rdi,dword ptr [rbp+28]
       mov       rcx,offset MT_System.Threading.Tasks.RangeManager
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       eax,eax
       mov       [r14+18],eax
       mov       qword ptr [r14+10],1
       mov       eax,2
       cmp       ebx,1
       cmove     ebx,eax
       mov       rcx,rdi
       sub       rcx,rsi
       movsxd    r8,ebx
       mov       rax,rcx
       xor       edx,edx
       div       r8
       mov       r8,rax
       mov       eax,1
       test      r8,r8
       cmove     r8,rax
       mov       rax,rcx
       xor       edx,edx
       div       r8
       mov       ebx,eax
       mov       rax,rcx
       xor       edx,edx
       div       r8
       lea       ecx,[rbx+1]
       test      rdx,rdx
       cmovne    ebx,ecx
       mov       r15,r8
       mov       byte ptr [r14+1C],0
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Threading.Tasks.IndexRange[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       test      ebx,ebx
       jle       short M01_L07
M01_L05:
       mov       rdx,[r14+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M01_L30
       mov       eax,ecx
       shl       rax,5
       lea       rdx,[rdx+rax+10]
       mov       [rdx+8],rsi
       xor       r8d,r8d
       mov       [rdx],r8
       mov       rdx,[r14+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M01_L30
       lea       rdx,[rdx+rax+10]
       mov       [rdx+18],r8d
       add       rsi,r15
       mov       rax,rsi
       sub       rax,r15
       cmp       rax,rsi
       jg        near ptr M01_L10
       cmp       rsi,rdi
       jg        near ptr M01_L10
M01_L06:
       mov       [rdx+10],rsi
       inc       ecx
       cmp       ecx,ebx
       jl        short M01_L05
M01_L07:
       mov       r8,[rbp-88]
       lea       rcx,[r8+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       r8,[rbp-88]
       mov       [r8+8],rcx
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       cmp       qword ptr [rbp-60],0
       jne       short M01_L09
       xor       ecx,ecx
       xor       eax,eax
M01_L08:
       mov       [rbp-58],rcx
       mov       [rbp-50],rax
       xor       ecx,ecx
       mov       [r8+50],ecx
       mov       rcx,2BAD6C04A70
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M01_L18
       jmp       near ptr M01_L19
M01_L09:
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       mov       rcx,offset MT_System.Action`1[[System.Object, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp-88]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset System.Threading.Tasks.Parallel+<>c__DisplayClass19_0`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].<ForWorker>b__0(System.Object)
       mov       [rbx+18],rdx
       mov       rcx,[rbp-60]
       test      rcx,rcx
       jne       short M01_L15
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-78],xmm0
       jmp       short M01_L16
M01_L10:
       mov       rsi,rdi
       jmp       near ptr M01_L06
M01_L11:
       mov       rcx,[r8+10]
       mov       ebx,[rcx+10]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        near ptr M01_L25
M01_L12:
       mov       rax,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [rcx],rax
       jne       near ptr M01_L26
       mov       esi,7FFFFFFF
M01_L13:
       test      esi,esi
       jle       short M01_L14
       cmp       esi,7FFFFFFF
       jne       near ptr M01_L27
M01_L14:
       cmp       ebx,0FFFFFFFF
       je        near ptr M01_L03
       mov       rcx,[r8+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E70C0]; System.Threading.Tasks.ParallelOptions.get_EffectiveMaxConcurrencyLevel()
       mov       ebx,eax
       jmp       near ptr M01_L04
M01_L15:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       lea       rdx,[rbp-78]
       mov       r8,rbx
       xor       r9d,r9d
       call      qword ptr [7FFB8C184D98]
M01_L16:
       mov       rcx,[rbp-78]
       mov       rax,[rbp-70]
       mov       r8,[rbp-88]
       jmp       near ptr M01_L08
M01_L17:
       mov       rcx,rsp
       call      M01_L32
       nop
       mov       r8,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [r8],xmm0
       mov       rax,[rbp-38]
       mov       [r8+10],rax
       movzx     eax,byte ptr [rbp-7C]
       mov       [r8],al
       mov       rax,r8
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       mov       rax,7FFB8C0DE540
       mov       ecx,1
       lock xadd [rax],ecx
       inc       ecx
       mov       r8,[rbp-88]
       mov       [r8+50],ecx
       mov       rax,2BAD6C04A70
       mov       rbx,[rax]
       call      qword ptr [7FFB8C0E71F8]
       mov       rcx,rax
       mov       rax,2BAD6C00918
       test      rcx,rcx
       cmove     rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7228]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       esi,eax
       call      qword ptr [7FFB8BE74420]
       mov       [rbp-68],rax
       mov       r8d,[rbp-64]
       mov       rax,[rbp-88]
       mov       r9d,[rax+50]
       movsxd    rcx,dword ptr [rbp+20]
       movsxd    rdx,dword ptr [rbp+28]
       mov       dword ptr [rsp+20],2
       mov       [rsp+28],rcx
       mov       [rsp+30],rdx
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFB8C0EC798]
       nop
M01_L19:
       jmp       short M01_L21
M01_L20:
       mov       rcx,[rdx+8]
       call      CORINFO_HELP_THROW
       int       3
M01_L21:
       mov       rcx,offset MT_System.Threading.Tasks.TaskReplicator+ReplicatableUserAction`1[[System.Threading.Tasks.RangeWorker, System.Threading.Tasks.Parallel]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp-88]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFB8C0E36A8
       mov       [rbx+18],rdx
       mov       rdx,[rbp-88]
       mov       rdx,[rdx+10]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFB8C0EC948]; System.Threading.Tasks.TaskReplicator.Run[[System.Threading.Tasks.RangeWorker, System.Threading.Tasks.Parallel]](ReplicatableUserAction`1<System.Threading.Tasks.RangeWorker>, System.Threading.Tasks.ParallelOptions, Boolean)
       nop
       mov       rdx,[rbp-88]
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       cmp       qword ptr [rbp-60],0
       je        short M01_L22
       lea       rcx,[rbp-58]
       call      qword ptr [7FFB8C0E76F0]
M01_L22:
       mov       rdx,[rbp-88]
       cmp       qword ptr [rdx+8],0
       jne       near ptr M01_L20
       jmp       near ptr M01_L17
M01_L23:
       nop
       mov       rdx,[rbp-88]
       jmp       near ptr M01_L17
M01_L24:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFB8BE75740]
       int       3
M01_L25:
       call      qword ptr [7FFB8C0E71F8]
       mov       rcx,2BAD6C00918
       test      rax,rax
       cmove     rax,[rcx]
       mov       rcx,rax
       mov       r8,[rbp-88]
       jmp       near ptr M01_L12
M01_L26:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       esi,eax
       mov       r8,[rbp-88]
       jmp       near ptr M01_L13
M01_L27:
       cmp       ebx,0FFFFFFFF
       je        short M01_L28
       cmp       esi,ebx
       cmovg     esi,ebx
       mov       ebx,esi
       jmp       short M01_L29
M01_L28:
       mov       ebx,esi
M01_L29:
       jmp       near ptr M01_L14
M01_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0D0]
       mov       rax,[rbp-88]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       cmp       qword ptr [rbp-60],0
       je        short M01_L31
       lea       rcx,[rbp-58]
       call      qword ptr [7FFB8C0E76F0]
M01_L31:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0D0]
       mov       rbx,rdx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7990]
       mov       rsi,rax
       mov       rax,[rbp-88]
       mov       rcx,[rax+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7090]; System.Threading.Tasks.ParallelOptions.get_CancellationToken()
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFB8C0E6328]
       lea       rax,[M01_L23]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L32:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0D0]
       mov       rdx,[rbp-88]
       mov       rax,[rdx+18]
       mov       ebx,[rax+8]
       xor       eax,eax
       test      ebx,ebx
       sete      al
       mov       [rbp-7C],eax
       test      bl,2
       je        short M01_L33
       mov       rdx,[rbp-88]
       mov       rcx,[rdx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7BA0]
       movsxd    rcx,eax
       mov       byte ptr [rbp-40],1
       mov       [rbp-38],rcx
M01_L33:
       mov       rax,2BAD6C04A70
       mov       rax,[rax]
       cmp       byte ptr [rax+9D],0
       je        near ptr M01_L37
       test      ebx,ebx
       jne       short M01_L34
       mov       r9d,[rbp+28]
       mov       esi,r9d
       sub       esi,[rbp+20]
       jmp       short M01_L36
M01_L34:
       test      bl,2
       je        short M01_L35
       mov       rdx,[rbp-88]
       mov       rcx,[rdx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7BA0]
       mov       esi,eax
       sub       esi,[rbp+20]
       jmp       short M01_L36
M01_L35:
       mov       esi,0FFFFFFFF
M01_L36:
       mov       rax,2BAD6C04A70
       mov       rbx,[rax]
       call      qword ptr [7FFB8C0E71F8]
       mov       rcx,rax
       mov       rax,2BAD6C00918
       test      rcx,rcx
       cmove     rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7228]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       edi,eax
       call      qword ptr [7FFB8BE74420]
       mov       [rbp-68],rax
       mov       r8d,[rbp-64]
       mov       rax,[rbp-88]
       mov       r9d,[rax+50]
       movsxd    rcx,esi
       mov       [rsp+20],rcx
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFB8C0EC7B0]
M01_L37:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1897
```

## .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
```assembly
; BenchmarkLocks.LockingParallel.Parallel_UseLock()
;             Parallel.For(0, max_runs_per_invoke, (_) =>
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             {
;              
;                 UseLock();
;                           
;             });
;                
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+80]
       mov       rbx,rcx
       mov       rcx,offset MT_System.Action`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+18]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB8BED0D38
       mov       [rsi+18],rcx
       mov       rcx,1CA5AC04A50
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       [rsp+28],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-30]
       mov       r9d,edi
       mov       rdx,offset MD_System.Threading.Tasks.Parallel.ForWorker[[System.Object, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.Object,System.Object>, System.Func`1<System.Object>, System.Action`1<System.Object>)
       xor       r8d,r8d
       call      qword ptr [7FFB8C0E64F0]; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 147
```
```assembly
; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       vzeroupper
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       [rbp-98],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L02
M01_L00:
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       [rbp-88],r8
       lea       rcx,[r8+10]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       lea       rcx,[r8+28]
       mov       rdx,[rbp+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       lea       rcx,[r8+30]
       mov       rdx,[rbp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       lea       rcx,[r8+38]
       mov       rdx,[rbp+50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       lea       rcx,[r8+40]
       mov       rdx,[rbp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       lea       rcx,[r8+48]
       mov       rdx,[rbp+58]
       call      CORINFO_HELP_ASSIGN_REF
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       vmovdqu   xmmword ptr [rbp-40],xmm0
       mov       r9d,[rbp+28]
       cmp       r9d,[rbp+20]
       jle       short M01_L01
       mov       rcx,offset MT_System.Threading.Tasks.ParallelLoopStateFlags`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+0C],7FFFFFFF
       mov       r8,[rbp-88]
       lea       rcx,[r8+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       cmp       qword ptr [rbp-60],0
       je        near ptr M01_L11
       mov       rcx,[rbp-60]
       cmp       dword ptr [rcx+20],0
       je        near ptr M01_L11
       jmp       near ptr M01_L25
M01_L01:
       mov       r8,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [r8],xmm0
       mov       rax,[rbp-38]
       mov       [r8+10],rax
       mov       byte ptr [r8],1
       mov       rax,r8
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       rcx,rdx
       mov       rdx,7FFB8C0F19F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L03:
       mov       ebx,14
M01_L04:
       movsxd    rsi,dword ptr [rbp+20]
       movsxd    rdi,dword ptr [rbp+28]
       mov       rcx,offset MT_System.Threading.Tasks.RangeManager
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       eax,eax
       mov       [r14+18],eax
       mov       qword ptr [r14+10],1
       mov       eax,2
       cmp       ebx,1
       cmove     ebx,eax
       mov       rcx,rdi
       sub       rcx,rsi
       movsxd    r8,ebx
       mov       rax,rcx
       xor       edx,edx
       div       r8
       mov       r8,rax
       mov       eax,1
       test      r8,r8
       cmove     r8,rax
       mov       rax,rcx
       xor       edx,edx
       div       r8
       mov       ebx,eax
       mov       rax,rcx
       xor       edx,edx
       div       r8
       lea       ecx,[rbx+1]
       test      rdx,rdx
       cmovne    ebx,ecx
       mov       r15,r8
       mov       byte ptr [r14+1C],0
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Threading.Tasks.IndexRange[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       test      ebx,ebx
       jle       short M01_L07
M01_L05:
       mov       rdx,[r14+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M01_L31
       mov       eax,ecx
       shl       rax,5
       lea       rdx,[rdx+rax+10]
       mov       [rdx+8],rsi
       xor       r8d,r8d
       mov       [rdx],r8
       mov       rdx,[r14+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M01_L31
       lea       rdx,[rdx+rax+10]
       mov       [rdx+18],r8d
       add       rsi,r15
       mov       rax,rsi
       sub       rax,r15
       cmp       rax,rsi
       jg        short M01_L08
       cmp       rsi,rdi
       jg        short M01_L08
M01_L06:
       mov       [rdx+10],rsi
       inc       ecx
       cmp       ecx,ebx
       jl        short M01_L05
M01_L07:
       mov       r8,[rbp-88]
       lea       rcx,[r8+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       r8,[rbp-88]
       mov       [r8+8],rcx
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       cmp       qword ptr [rbp-60],0
       je        short M01_L13
       jmp       near ptr M01_L15
M01_L08:
       mov       rsi,rdi
       jmp       short M01_L06
M01_L09:
       test      esi,esi
       jle       short M01_L10
       cmp       esi,7FFFFFFF
       jne       near ptr M01_L28
M01_L10:
       cmp       ebx,0FFFFFFFF
       je        near ptr M01_L03
       mov       rcx,[r8+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E70C0]; System.Threading.Tasks.ParallelOptions.get_EffectiveMaxConcurrencyLevel()
       mov       ebx,eax
       jmp       near ptr M01_L04
M01_L11:
       mov       rcx,[r8+10]
       mov       ebx,[rcx+10]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        near ptr M01_L26
M01_L12:
       mov       rax,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [rcx],rax
       jne       near ptr M01_L27
       mov       esi,7FFFFFFF
       jmp       short M01_L09
M01_L13:
       xor       ebx,ebx
       xor       esi,esi
M01_L14:
       mov       [rbp-58],rbx
       mov       [rbp-50],rsi
       xor       ecx,ecx
       mov       [r8+50],ecx
       mov       rcx,1CA5AC04A70
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M01_L19
       jmp       near ptr M01_L20
M01_L15:
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       mov       rcx,offset MT_System.Action`1[[System.Object, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp-88]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset System.Threading.Tasks.Parallel+<>c__DisplayClass19_0`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].<ForWorker>b__0(System.Object)
       mov       [rbx+18],rdx
       mov       rcx,[rbp-60]
       test      rcx,rcx
       jne       short M01_L16
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-78],xmm0
       jmp       short M01_L17
M01_L16:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       lea       rdx,[rbp-78]
       mov       r8,rbx
       xor       r9d,r9d
       call      qword ptr [7FFB8C1941E0]
M01_L17:
       mov       rbx,[rbp-78]
       mov       rsi,[rbp-70]
       mov       r8,[rbp-88]
       jmp       near ptr M01_L14
M01_L18:
       mov       rcx,rsp
       call      M01_L33
       nop
       mov       r8,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [r8],xmm0
       mov       rax,[rbp-38]
       mov       [r8+10],rax
       movzx     eax,byte ptr [rbp-7C]
       mov       [r8],al
       mov       rax,r8
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       rax,7FFB8C0DE540
       mov       ecx,1
       lock xadd [rax],ecx
       inc       ecx
       mov       [r8+50],ecx
       mov       rax,1CA5AC04A70
       mov       rbx,[rax]
       call      qword ptr [7FFB8C0E71F8]
       mov       rcx,rax
       mov       rax,1CA5AC00918
       test      rcx,rcx
       cmove     rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7228]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       esi,eax
       call      qword ptr [7FFB8BE74420]
       mov       [rbp-68],rax
       mov       r8d,[rbp-64]
       mov       rax,[rbp-88]
       mov       r9d,[rax+50]
       movsxd    rcx,dword ptr [rbp+20]
       movsxd    rdx,dword ptr [rbp+28]
       mov       dword ptr [rsp+20],2
       mov       [rsp+28],rcx
       mov       [rsp+30],rdx
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFB8C0EC798]
       mov       r8,[rbp-88]
M01_L20:
       jmp       short M01_L22
M01_L21:
       mov       rcx,[rdx+8]
       call      CORINFO_HELP_THROW
       int       3
M01_L22:
       mov       rcx,offset MT_System.Threading.Tasks.TaskReplicator+ReplicatableUserAction`1[[System.Threading.Tasks.RangeWorker, System.Threading.Tasks.Parallel]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp-88]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFB8C0E36A8
       mov       [rbx+18],rdx
       mov       rdx,[rbp-88]
       mov       rdx,[rdx+10]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFB8C0EC948]; System.Threading.Tasks.TaskReplicator.Run[[System.Threading.Tasks.RangeWorker, System.Threading.Tasks.Parallel]](ReplicatableUserAction`1<System.Threading.Tasks.RangeWorker>, System.Threading.Tasks.ParallelOptions, Boolean)
       nop
       mov       rdx,[rbp-88]
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       cmp       qword ptr [rbp-60],0
       je        short M01_L23
       lea       rcx,[rbp-58]
       call      qword ptr [7FFB8C0E76F0]
M01_L23:
       mov       rdx,[rbp-88]
       cmp       qword ptr [rdx+8],0
       jne       near ptr M01_L21
       jmp       near ptr M01_L18
M01_L24:
       nop
       mov       rdx,[rbp-88]
       jmp       near ptr M01_L18
M01_L25:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFB8BE75740]
       int       3
M01_L26:
       call      qword ptr [7FFB8C0E71F8]
       mov       rcx,1CA5AC00918
       test      rax,rax
       cmove     rax,[rcx]
       mov       rcx,rax
       mov       r8,[rbp-88]
       jmp       near ptr M01_L12
M01_L27:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       esi,eax
       mov       r8,[rbp-88]
       jmp       near ptr M01_L09
M01_L28:
       cmp       ebx,0FFFFFFFF
       je        short M01_L29
       cmp       esi,ebx
       cmovg     esi,ebx
       mov       ebx,esi
       jmp       short M01_L30
M01_L29:
       mov       ebx,esi
M01_L30:
       jmp       near ptr M01_L10
M01_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0D0]
       mov       rax,[rbp-88]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       cmp       qword ptr [rbp-60],0
       je        short M01_L32
       lea       rcx,[rbp-58]
       call      qword ptr [7FFB8C0E76F0]
M01_L32:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0D0]
       mov       rbx,rdx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7990]
       mov       rsi,rax
       mov       rax,[rbp-88]
       mov       rcx,[rax+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7090]; System.Threading.Tasks.ParallelOptions.get_CancellationToken()
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFB8C0E6328]
       lea       rax,[M01_L24]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L33:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0D0]
       mov       rdx,[rbp-88]
       mov       rax,[rdx+18]
       mov       ebx,[rax+8]
       xor       eax,eax
       test      ebx,ebx
       sete      al
       mov       [rbp-7C],eax
       test      bl,2
       je        short M01_L34
       mov       rdx,[rbp-88]
       mov       rcx,[rdx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7BA0]
       movsxd    rcx,eax
       mov       byte ptr [rbp-40],1
       mov       [rbp-38],rcx
M01_L34:
       mov       rax,1CA5AC04A70
       mov       rax,[rax]
       cmp       byte ptr [rax+9D],0
       je        near ptr M01_L38
       test      ebx,ebx
       jne       short M01_L35
       mov       r9d,[rbp+28]
       mov       esi,r9d
       sub       esi,[rbp+20]
       jmp       short M01_L37
M01_L35:
       test      bl,2
       je        short M01_L36
       mov       rdx,[rbp-88]
       mov       rcx,[rdx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7BA0]
       mov       esi,eax
       sub       esi,[rbp+20]
       jmp       short M01_L37
M01_L36:
       mov       esi,0FFFFFFFF
M01_L37:
       mov       rax,1CA5AC04A70
       mov       rbx,[rax]
       call      qword ptr [7FFB8C0E71F8]
       mov       rcx,rax
       mov       rax,1CA5AC00918
       test      rcx,rcx
       cmove     rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C0E7228]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       edi,eax
       call      qword ptr [7FFB8BE74420]
       mov       [rbp-68],rax
       mov       r8d,[rbp-64]
       mov       rax,[rbp-88]
       mov       r9d,[rax+50]
       movsxd    rcx,esi
       mov       [rsp+20],rcx
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFB8C0EC7B0]
M01_L38:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1892
```

## .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
```assembly
; BenchmarkLocks.LockingParallel.Parallel_UseInterLock()
;             Parallel.For(0, max_runs_per_invoke, (_) =>
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             {
;              
;                 UseInterLockSpin();
;                                    
;             });
;                
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+80]
       mov       rbx,rcx
       mov       rcx,offset MT_System.Action`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+18]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB8BF00D50
       mov       [rsi+18],rcx
       mov       rcx,2530D804A50
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       [rsp+28],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-30]
       mov       r9d,edi
       mov       rdx,offset MD_System.Threading.Tasks.Parallel.ForWorker[[System.Object, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.Object,System.Object>, System.Func`1<System.Object>, System.Action`1<System.Object>)
       xor       r8d,r8d
       call      qword ptr [7FFB8C116598]; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 147
```
```assembly
; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       vzeroupper
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       [rbp-98],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L15
M01_L00:
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       [rbp-88],r8
       lea       rcx,[r8+10]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       lea       rcx,[r8+28]
       mov       rdx,[rbp+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       lea       rcx,[r8+30]
       mov       rdx,[rbp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       lea       rcx,[r8+38]
       mov       rdx,[rbp+50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       lea       rcx,[r8+40]
       mov       rdx,[rbp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       lea       rcx,[r8+48]
       mov       rdx,[rbp+58]
       call      CORINFO_HELP_ASSIGN_REF
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       vmovdqu   xmmword ptr [rbp-40],xmm0
       mov       r9d,[rbp+28]
       cmp       r9d,[rbp+20]
       jle       near ptr M01_L14
       mov       rcx,offset MT_System.Threading.Tasks.ParallelLoopStateFlags`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+0C],7FFFFFFF
       mov       r8,[rbp-88]
       lea       rcx,[r8+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-88]
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L13
M01_L01:
       mov       rcx,[r8+10]
       mov       ebx,[rcx+10]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        near ptr M01_L25
M01_L02:
       mov       rax,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [rcx],rax
       jne       near ptr M01_L27
       mov       esi,7FFFFFFF
M01_L03:
       test      esi,esi
       jle       short M01_L04
       cmp       esi,7FFFFFFF
       jne       near ptr M01_L30
M01_L04:
       cmp       ebx,0FFFFFFFF
       jne       near ptr M01_L16
       mov       ebx,14
M01_L05:
       movsxd    rsi,dword ptr [rbp+20]
       movsxd    rdi,dword ptr [rbp+28]
       mov       rcx,offset MT_System.Threading.Tasks.RangeManager
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       eax,eax
       mov       [r14+18],eax
       mov       qword ptr [r14+10],1
       mov       eax,2
       cmp       ebx,1
       cmove     ebx,eax
       mov       rcx,rdi
       sub       rcx,rsi
       movsxd    r8,ebx
       mov       rax,rcx
       xor       edx,edx
       div       r8
       mov       r8,rax
       mov       eax,1
       test      r8,r8
       cmove     r8,rax
       mov       rax,rcx
       xor       edx,edx
       div       r8
       mov       ebx,eax
       mov       rax,rcx
       xor       edx,edx
       div       r8
       lea       ecx,[rbx+1]
       test      rdx,rdx
       cmovne    ebx,ecx
       mov       r15,r8
       mov       byte ptr [r14+1C],0
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Threading.Tasks.IndexRange[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       test      ebx,ebx
       jle       short M01_L08
M01_L06:
       mov       rdx,[r14+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M01_L31
       mov       eax,ecx
       shl       rax,5
       lea       rdx,[rdx+rax+10]
       mov       [rdx+8],rsi
       xor       r8d,r8d
       mov       [rdx],r8
       mov       rdx,[r14+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M01_L31
       lea       rdx,[rdx+rax+10]
       mov       [rdx+18],r8d
       add       rsi,r15
       mov       rax,rsi
       sub       rax,r15
       cmp       rax,rsi
       jg        near ptr M01_L11
       cmp       rsi,rdi
       jg        near ptr M01_L11
M01_L07:
       mov       [rdx+10],rsi
       inc       ecx
       cmp       ecx,ebx
       jl        short M01_L06
M01_L08:
       mov       r8,[rbp-88]
       lea       rcx,[r8+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       r8,[rbp-88]
       mov       [r8+8],rcx
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       cmp       qword ptr [rbp-60],0
       jne       short M01_L10
       xor       ecx,ecx
       xor       eax,eax
M01_L09:
       mov       [rbp-58],rcx
       mov       [rbp-50],rax
       xor       ecx,ecx
       mov       [r8+50],ecx
       mov       rcx,2530D804A70
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M01_L19
       jmp       near ptr M01_L20
M01_L10:
       mov       rcx,[r8+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       mov       rcx,offset MT_System.Action`1[[System.Object, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp-88]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset System.Threading.Tasks.Parallel+<>c__DisplayClass19_0`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].<ForWorker>b__0(System.Object)
       mov       [rbx+18],rdx
       mov       rcx,[rbp-60]
       test      rcx,rcx
       jne       near ptr M01_L17
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-78],xmm0
       jmp       near ptr M01_L18
M01_L11:
       mov       rsi,rdi
       jmp       near ptr M01_L07
M01_L12:
       mov       rcx,rsp
       call      M01_L33
       nop
       mov       r8,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [r8],xmm0
       mov       rax,[rbp-38]
       mov       [r8+10],rax
       movzx     eax,byte ptr [rbp-7C]
       mov       [r8],al
       mov       rax,r8
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L13:
       mov       rcx,[rbp-60]
       cmp       dword ptr [rcx+20],0
       je        near ptr M01_L01
       jmp       near ptr M01_L26
M01_L14:
       mov       r8,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [r8],xmm0
       mov       rax,[rbp-38]
       mov       [r8+10],rax
       mov       byte ptr [r8],1
       mov       rax,r8
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L15:
       mov       rcx,rdx
       mov       rdx,7FFB8C1219F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L16:
       mov       rcx,[r8+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C117168]; System.Threading.Tasks.ParallelOptions.get_EffectiveMaxConcurrencyLevel()
       mov       ebx,eax
       jmp       near ptr M01_L05
M01_L17:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       lea       rdx,[rbp-78]
       mov       r8,rbx
       xor       r9d,r9d
       call      qword ptr [7FFB8C1B4D98]
M01_L18:
       mov       rcx,[rbp-78]
       mov       rax,[rbp-70]
       mov       r8,[rbp-88]
       jmp       near ptr M01_L09
M01_L19:
       mov       rax,7FFB8C10E350
       mov       ecx,1
       lock xadd [rax],ecx
       inc       ecx
       mov       r8,[rbp-88]
       mov       [r8+50],ecx
       mov       rax,2530D804A70
       mov       rbx,[rax]
       call      qword ptr [7FFB8C1172A0]
       mov       rcx,rax
       mov       rax,2530D800918
       test      rcx,rcx
       cmove     rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C1172D0]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       esi,eax
       call      qword ptr [7FFB8BEA4420]
       mov       [rbp-68],rax
       mov       r8d,[rbp-64]
       mov       rax,[rbp-88]
       mov       r9d,[rax+50]
       movsxd    rcx,dword ptr [rbp+20]
       movsxd    rdx,dword ptr [rbp+28]
       mov       dword ptr [rsp+20],2
       mov       [rsp+28],rcx
       mov       [rsp+30],rdx
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFB8C11C798]
       nop
M01_L20:
       jmp       short M01_L22
M01_L21:
       mov       rcx,[rdx+8]
       call      CORINFO_HELP_THROW
       int       3
M01_L22:
       mov       rcx,offset MT_System.Threading.Tasks.TaskReplicator+ReplicatableUserAction`1[[System.Threading.Tasks.RangeWorker, System.Threading.Tasks.Parallel]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp-88]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFB8C113750
       mov       [rbx+18],rdx
       mov       rdx,[rbp-88]
       mov       rdx,[rdx+10]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFB8C11C948]; System.Threading.Tasks.TaskReplicator.Run[[System.Threading.Tasks.RangeWorker, System.Threading.Tasks.Parallel]](ReplicatableUserAction`1<System.Threading.Tasks.RangeWorker>, System.Threading.Tasks.ParallelOptions, Boolean)
       nop
       mov       rdx,[rbp-88]
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       cmp       qword ptr [rbp-60],0
       je        short M01_L23
       lea       rcx,[rbp-58]
       call      qword ptr [7FFB8C117798]
M01_L23:
       mov       rdx,[rbp-88]
       cmp       qword ptr [rdx+8],0
       jne       near ptr M01_L21
       jmp       near ptr M01_L12
M01_L24:
       nop
       mov       rdx,[rbp-88]
       jmp       near ptr M01_L12
M01_L25:
       call      qword ptr [7FFB8C1172A0]
       mov       rcx,2530D800918
       test      rax,rax
       cmove     rax,[rcx]
       mov       rcx,rax
       mov       r8,[rbp-88]
       jmp       near ptr M01_L02
M01_L26:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFB8BEA5740]
       int       3
M01_L27:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       esi,eax
       mov       r8,[rbp-88]
       jmp       near ptr M01_L03
M01_L28:
       mov       ebx,esi
M01_L29:
       jmp       near ptr M01_L04
M01_L30:
       cmp       ebx,0FFFFFFFF
       je        short M01_L28
       cmp       esi,ebx
       cmovg     esi,ebx
       mov       ebx,esi
       jmp       short M01_L29
M01_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0D0]
       mov       rax,[rbp-88]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       cmp       qword ptr [rbp-60],0
       je        short M01_L32
       lea       rcx,[rbp-58]
       call      qword ptr [7FFB8C117798]
M01_L32:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0D0]
       mov       rbx,rdx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C117A38]
       mov       rsi,rax
       mov       rax,[rbp-88]
       mov       rcx,[rax+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C117138]; System.Threading.Tasks.ParallelOptions.get_CancellationToken()
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFB8C1163D0]
       lea       rax,[M01_L24]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L33:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0D0]
       mov       rdx,[rbp-88]
       mov       rax,[rdx+18]
       mov       ebx,[rax+8]
       xor       eax,eax
       test      ebx,ebx
       sete      al
       mov       [rbp-7C],eax
       test      bl,2
       je        short M01_L34
       mov       rdx,[rbp-88]
       mov       rcx,[rdx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C117C48]
       movsxd    rcx,eax
       mov       byte ptr [rbp-40],1
       mov       [rbp-38],rcx
M01_L34:
       mov       rax,2530D804A70
       mov       rax,[rax]
       cmp       byte ptr [rax+9D],0
       je        near ptr M01_L38
       test      ebx,ebx
       jne       short M01_L35
       mov       r9d,[rbp+28]
       mov       esi,r9d
       sub       esi,[rbp+20]
       jmp       short M01_L37
M01_L35:
       test      bl,2
       je        short M01_L36
       mov       rdx,[rbp-88]
       mov       rcx,[rdx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C117C48]
       mov       esi,eax
       sub       esi,[rbp+20]
       jmp       short M01_L37
M01_L36:
       mov       esi,0FFFFFFFF
M01_L37:
       mov       rax,2530D804A70
       mov       rbx,[rax]
       call      qword ptr [7FFB8C1172A0]
       mov       rcx,rax
       mov       rax,2530D800918
       test      rcx,rcx
       cmove     rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8C1172D0]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       edi,eax
       call      qword ptr [7FFB8BEA4420]
       mov       [rbp-68],rax
       mov       r8d,[rbp-64]
       mov       rax,[rbp-88]
       mov       r9d,[rax+50]
       movsxd    rcx,esi
       mov       [rsp+20],rcx
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFB8C11C7B0]
M01_L38:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1908
```

