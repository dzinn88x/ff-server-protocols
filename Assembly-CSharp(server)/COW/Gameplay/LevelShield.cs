using System;
using GCommon;
using Il2CppDummyDll;

namespace COW.GamePlay
{
	// Token: 0x0200289F RID: 10399
	[Token(Token = "0x200289F")]
	internal class LevelShield : BaseLevelObject
	{
		// Token: 0x0600DC64 RID: 56420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DC64")]
		[Address(RVA = "0x1D3BAF8", Offset = "0x1D3BAF8", VA = "0x7BBC53BAF8", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x0600DC65 RID: 56421 RVA: 0x0003CF78 File Offset: 0x0003B178
		[Token(Token = "0x600DC65")]
		[Address(RVA = "0x1D3BB40", Offset = "0x1D3BB40", VA = "0x7BBC53BB40", Slot = "22")]
		protected override int GetMaxRepDataCount()
		{
			return 0;
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x0600DC66 RID: 56422 RVA: 0x0003CF90 File Offset: 0x0003B190
		// (set) Token: 0x0600DC67 RID: 56423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000F00")]
		public uint L\u0081}\u007FslP
		{
			[Token(Token = "0x600DC66")]
			[Address(RVA = "0x1D3BB48", Offset = "0x1D3BB48", VA = "0x7BBC53BB48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1149944", Offset = "0x1149944")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600DC67")]
			[Address(RVA = "0x1D3BB50", Offset = "0x1D3BB50", VA = "0x7BBC53BB50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1149954", Offset = "0x1149954")]
			private set
			{
			}
		}

		// Token: 0x0600DC68 RID: 56424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC68")]
		[Address(RVA = "0x1D3BB58", Offset = "0x1D3BB58", VA = "0x7BBC53BB58")]
		public void BindWithVehicle(Vehicle p~xds~z)
		{
		}

		// Token: 0x0600DC69 RID: 56425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC69")]
		[Address(RVA = "0x1D3BE7C", Offset = "0x1D3BE7C", VA = "0x7BBC53BE7C", Slot = "20")]
		protected override void OnUserDefineReplicationInfo()
		{
		}

		// Token: 0x0600DC6A RID: 56426 RVA: 0x0003CFA8 File Offset: 0x0003B1A8
		[Token(Token = "0x600DC6A")]
		[Address(RVA = "0x1D3BFDC", Offset = "0x1D3BFDC", VA = "0x7BBC53BFDC", Slot = "35")]
		public virtual uint GetMaxHP()
		{
			return 0U;
		}

		// Token: 0x0600DC6B RID: 56427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC6B")]
		[Address(RVA = "0x1D3C044", Offset = "0x1D3C044", VA = "0x7BBC53C044", Slot = "36")]
		protected virtual void ^}somrQ(int l]jgxbG, int TzzPYjI)
		{
		}

		// Token: 0x0600DC6C RID: 56428 RVA: 0x0003CFC0 File Offset: 0x0003B1C0
		[Token(Token = "0x600DC6C")]
		[Address(RVA = "0x1D3C51C", Offset = "0x1D3C51C", VA = "0x7BBC53C51C", Slot = "37")]
		public virtual ResourceID GetModelResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600DC6D RID: 56429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC6D")]
		[Address(RVA = "0x1D3C56C", Offset = "0x1D3C56C", VA = "0x7BBC53C56C")]
		public LevelShield()
		{
		}

		// Token: 0x04010BA5 RID: 68517
		[Token(Token = "0x4010BA5")]
		[FieldOffset(Offset = "0x68")]
		private Shield bi\u0082pb\u0080p;

		// Token: 0x04010BA6 RID: 68518
		[Token(Token = "0x4010BA6")]
		[FieldOffset(Offset = "0x70")]
		private Vehicle PIRCQqt;

		// Token: 0x04010BA7 RID: 68519
		[Token(Token = "0x4010BA7")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1130F64", Offset = "0x1130F64")]
		private uint <QEXbHN\u007F>k__BackingField;
	}
}
