using System;
using Il2CppDummyDll;

namespace COW.GamePlay
{
	// Token: 0x02002828 RID: 10280
	[Token(Token = "0x2002828")]
	public class LevelAmmoBox : BaseLevelObject
	{
		// Token: 0x0600D866 RID: 55398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D866")]
		[Address(RVA = "0x157C740", Offset = "0x157C740", VA = "0x7BBBD7C740", Slot = "26")]
		public override void DoAction(params object[] OSvO{nh)
		{
		}

		// Token: 0x0600D867 RID: 55399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D867")]
		[Address(RVA = "0x157C94C", Offset = "0x157C94C", VA = "0x7BBBD7C94C", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x0600D868 RID: 55400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D868")]
		[Address(RVA = "0x157C994", Offset = "0x157C994", VA = "0x7BBBD7C994")]
		public LevelAmmoBox()
		{
		}

		// Token: 0x040108C6 RID: 67782
		[Token(Token = "0x40108C6")]
		[FieldOffset(Offset = "0x68")]
		public int ItemID;

		// Token: 0x040108C7 RID: 67783
		[Token(Token = "0x40108C7")]
		[FieldOffset(Offset = "0x6C")]
		public int ItemCount;
	}
}
