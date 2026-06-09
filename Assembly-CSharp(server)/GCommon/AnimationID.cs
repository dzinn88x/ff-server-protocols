using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000EED RID: 3821
	[Token(Token = "0x2000EED")]
	public struct AnimationID
	{
		// Token: 0x06003548 RID: 13640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003548")]
		[Address(RVA = "0x11F6BA8", Offset = "0x11F6BA8", VA = "0x7BBB9F6BA8")]
		private AnimationID(int value)
		{
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x00010038 File Offset: 0x0000E238
		[Token(Token = "0x6003549")]
		[Address(RVA = "0x25D8940", Offset = "0x25D8940", VA = "0x7BBCDD8940")]
		public static implicit operator int(AnimationID id)
		{
			return 0;
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x00010050 File Offset: 0x0000E250
		[Token(Token = "0x600354A")]
		[Address(RVA = "0x25D8ECC", Offset = "0x25D8ECC", VA = "0x7BBCDD8ECC")]
		public static implicit operator AnimationID(int value)
		{
			return default(AnimationID);
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x00010068 File Offset: 0x0000E268
		[Token(Token = "0x600354B")]
		[Address(RVA = "0x25D9324", Offset = "0x25D9324", VA = "0x7BBCDD9324")]
		public static bool operator ==(AnimationID a, AnimationID b)
		{
			return default(bool);
		}

		// Token: 0x0600354C RID: 13644 RVA: 0x00010080 File Offset: 0x0000E280
		[Token(Token = "0x600354C")]
		[Address(RVA = "0x25D9330", Offset = "0x25D9330", VA = "0x7BBCDD9330")]
		public static bool operator !=(AnimationID a, AnimationID b)
		{
			return default(bool);
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600354D")]
		[Address(RVA = "0x11F6BB0", Offset = "0x11F6BB0", VA = "0x7BBB9F6BB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x00010098 File Offset: 0x0000E298
		[Token(Token = "0x600354E")]
		[Address(RVA = "0x11F6BDC", Offset = "0x11F6BDC", VA = "0x7BBB9F6BDC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x000100B0 File Offset: 0x0000E2B0
		[Token(Token = "0x600354F")]
		[Address(RVA = "0x11F6BE4", Offset = "0x11F6BE4", VA = "0x7BBB9F6BE4", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x000100C8 File Offset: 0x0000E2C8
		[Token(Token = "0x6003550")]
		[Address(RVA = "0x11F6C10", Offset = "0x11F6C10", VA = "0x7BBB9F6C10")]
		public int GetLayerIndex()
		{
			return 0;
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x000100E0 File Offset: 0x0000E2E0
		[Token(Token = "0x6003551")]
		[Address(RVA = "0x11F6C24", Offset = "0x11F6C24", VA = "0x7BBB9F6C24")]
		public int GetID()
		{
			return 0;
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x000100F8 File Offset: 0x0000E2F8
		[Token(Token = "0x6003552")]
		[Address(RVA = "0x25D8E40", Offset = "0x25D8E40", VA = "0x7BBCDD8E40")]
		public static int MakeAnimationID(int id, int layerIndex = 0)
		{
			return 0;
		}

		// Token: 0x040048AC RID: 18604
		[Token(Token = "0x40048AC")]
		[FieldOffset(Offset = "0x0")]
		private readonly int m_Value;

		// Token: 0x040048AD RID: 18605
		[Token(Token = "0x40048AD")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AnimationID INVALID;
	}
}
