﻿namespace LLVMSharp
{
    public sealed class AtomicCmpXchgInst : Instruction
    {
        internal AtomicCmpXchgInst(LLVMValueRef value)
            : base(value)
        {
        }
    }
}