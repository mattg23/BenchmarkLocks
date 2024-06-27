## .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
```assembly
; BenchmarkLocks.LockingDontWait.NoLock()
;             unchecked { value += 1; }
;                         ^^^^^^^^^^^
       vzeroupper
       vmovsd    xmm0,qword ptr [rcx+10]
       vaddsd    xmm0,xmm0,qword ptr [7FFB8BD26A88]
       vmovsd    qword ptr [rcx+10],xmm0
       ret
; Total bytes of code 22
```

## .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
```assembly
; BenchmarkLocks.LockingDontWait.UseLock()
;             bool lockTaken = false;
;             ^^^^^^^^^^^^^^^^^^^^^^^
;                 lockTaken = Monitor.TryEnter(mutex);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 if (lockTaken)
;                 ^^^^^^^^^^^^^^
;                     unchecked { value += 1; }
;                                 ^^^^^^^^^^^
;             return value;
;             ^^^^^^^^^^^^^
;             catch (Exception)
;             ^^^^^^^^^^^^^^^^^
;                 throw;
;                 ^^^^^^
;                 if (lockTaken)
;                 ^^^^^^^^^^^^^^
;                     Monitor.Exit(mutex);
;                     ^^^^^^^^^^^^^^^^^^^^
;             }
;             ^
       push      rbp
       sub       rsp,40
       vzeroupper
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-20],rsp
       mov       [rbp+10],rcx
       xor       r8d,r8d
       mov       [rbp-4],r8d
       mov       rdx,[rcx+8]
       cmp       byte ptr [rbp-10],0
       jne       short M00_L00
       lea       r8,[rbp-10]
       mov       rcx,rdx
       xor       edx,edx
       call      System.Threading.Monitor.ReliableEnterTimeout(System.Object, Int32, Boolean ByRef)
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFB8BCDE040]
       int       3
M00_L01:
       movzx     ecx,byte ptr [rbp-10]
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M00_L02
       mov       rcx,[rbp+10]
       vmovsd    xmm0,qword ptr [rcx+10]
       vaddsd    xmm0,xmm0,qword ptr [7FFB8BD06F08]
       vmovsd    qword ptr [rcx+10],xmm0
M00_L02:
       cmp       dword ptr [rbp-4],0
       je        short M00_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      System.Threading.Monitor.Exit(System.Object)
M00_L03:
       mov       rcx,[rbp+10]
       vmovsd    xmm0,qword ptr [rcx+10]
       add       rsp,40
       pop       rbp
       ret
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       call      CORINFO_HELP_RETHROW
       int       3
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       dword ptr [rbp-4],0
       je        short M00_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      System.Threading.Monitor.Exit(System.Object)
M00_L04:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 210
```
**Extern method**
System.Threading.Monitor.ReliableEnterTimeout(System.Object, Int32, Boolean ByRef)
System.Threading.Monitor.Exit(System.Object)

## .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
```assembly
; BenchmarkLocks.LockingDontWait.UseInterLockSpin()
;             if (System.Threading.Interlocked.CompareExchange(ref atomicMutex, LOCKED, UNLOCKED) == UNLOCKED)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 unchecked { value += 1; }
;                             ^^^^^^^^^^^
;                 System.Threading.Interlocked.Exchange(ref atomicMutex, UNLOCKED);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             return value;
;             ^^^^^^^^^^^^^
       vzeroupper
       cmp       [rcx],cl
       lea       rdx,[rcx+18]
       mov       r8d,1
       xor       eax,eax
       lock cmpxchg [rdx],r8d
       test      eax,eax
       jne       short M00_L00
       vmovsd    xmm0,qword ptr [rcx+10]
       vaddsd    xmm0,xmm0,qword ptr [7FFB8BD36D18]
       vmovsd    qword ptr [rcx+10],xmm0
       xor       eax,eax
       xchg      eax,[rdx]
M00_L00:
       vmovsd    xmm0,qword ptr [rcx+10]
       ret
; Total bytes of code 54
```

