## .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
```assembly
; BenchmarkLocks.LockingBase.NoLock()
;             unchecked { value += 1; }
;                         ^^^^^^^^^^^
       vzeroupper
       vmovsd    xmm0,qword ptr [rcx+10]
       vaddsd    xmm0,xmm0,qword ptr [7FFB8BD36A88]
       vmovsd    qword ptr [rcx+10],xmm0
       ret
; Total bytes of code 22
```

## .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
```assembly
; BenchmarkLocks.LockingBase.UseLock()
;             lock (mutex)
;             ^^^^^^^^^^^^
;                 unchecked { value += 1; }
;                             ^^^^^^^^^^^
;                 return value;
;                 ^^^^^^^^^^^^^
;         }
;         ^
       push      rbp
       push      rbx
       sub       rsp,48
       vzeroupper
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-30],rsp
       mov       rbx,rcx
       mov       rcx,[rbx+8]
       mov       [rbp-20],rcx
       cmp       byte ptr [rbp-10],0
       jne       short M00_L00
       lea       rdx,[rbp-10]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFB8BCFE040]
       int       3
M00_L01:
       vmovsd    xmm0,qword ptr [rbx+10]
       vaddsd    xmm0,xmm0,qword ptr [7FFB8BD26ED0]
       vmovsd    qword ptr [rbx+10],xmm0
       vmovsd    qword ptr [rbp-18],xmm0
       cmp       byte ptr [rbp-10],0
       je        short M00_L02
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M00_L02:
       vmovsd    xmm0,qword ptr [rbp-18]
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
       push      rbp
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-10],0
       je        short M00_L03
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M00_L03:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 154
```
**Extern method**
System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
System.Threading.Monitor.Exit(System.Object)

## .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
```assembly
; BenchmarkLocks.LockingBase.UseInterLockSpin()
;             var s = new SpinWait();
;             ^^^^^^^^^^^^^^^^^^^^^^^
;             bool isDone = false;
;             ^^^^^^^^^^^^^^^^^^^^
;                 if (System.Threading.Interlocked.CompareExchange(ref atomicMutex, LOCKED, UNLOCKED) == UNLOCKED)
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     unchecked { value += 1; }
;                                 ^^^^^^^^^^^
;                     isDone = true;
;                     ^^^^^^^^^^^^^^
;                     System.Threading.Interlocked.Exchange(ref atomicMutex, UNLOCKED);
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     s.SpinOnce();
;                     ^^^^^^^^^^^^^
;             } while (!isDone);
;               ^^^^^^^^^^^^^^^^
;             return value;
;             ^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       xor       esi,esi
M00_L00:
       cmp       [rbx],bl
       lea       rcx,[rbx+18]
       mov       edx,1
       xor       eax,eax
       lock cmpxchg [rcx],edx
       test      eax,eax
       jne       short M00_L01
       vmovsd    xmm0,qword ptr [rbx+10]
       vaddsd    xmm0,xmm0,qword ptr [7FFB8BD26E28]
       vmovsd    qword ptr [rbx+10],xmm0
       xor       edx,edx
       xchg      edx,[rcx]
       jmp       short M00_L02
M00_L01:
       lea       rcx,[rsp+20]
       mov       edx,14
       call      qword ptr [7FFB8C0F5FF8]
       test      esi,esi
       je        short M00_L00
M00_L02:
       vmovsd    xmm0,qword ptr [rbx+10]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 98
```

