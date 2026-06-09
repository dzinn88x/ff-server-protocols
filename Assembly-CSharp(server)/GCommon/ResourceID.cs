using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FF4 RID: 4084
	[Token(Token = "0x2000FF4")]
	public struct ResourceID : IEquatable<ResourceID>
	{
		// Token: 0x06003C95 RID: 15509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C95")]
		[Address(RVA = "0x11F24B0", Offset = "0x11F24B0", VA = "0x7BBB9F24B0")]
		private ResourceID(uint value)
		{
		}

		// Token: 0x06003C96 RID: 15510 RVA: 0x00012ED0 File Offset: 0x000110D0
		[Token(Token = "0x6003C96")]
		[Address(RVA = "0x2481AB0", Offset = "0x2481AB0", VA = "0x7BBCC81AB0")]
		public static implicit operator uint(ResourceID id)
		{
			return 0U;
		}

		// Token: 0x06003C97 RID: 15511 RVA: 0x00012EE8 File Offset: 0x000110E8
		[Token(Token = "0x6003C97")]
		[Address(RVA = "0x2481AB4", Offset = "0x2481AB4", VA = "0x7BBCC81AB4")]
		public static implicit operator ResourceID(uint value)
		{
			return default(ResourceID);
		}

		// Token: 0x06003C98 RID: 15512 RVA: 0x00012F00 File Offset: 0x00011100
		[Token(Token = "0x6003C98")]
		[Address(RVA = "0x2481ABC", Offset = "0x2481ABC", VA = "0x7BBCC81ABC")]
		public static bool operator ==(ResourceID a, ResourceID b)
		{
			return default(bool);
		}

		// Token: 0x06003C99 RID: 15513 RVA: 0x00012F18 File Offset: 0x00011118
		[Token(Token = "0x6003C99")]
		[Address(RVA = "0x2481AC8", Offset = "0x2481AC8", VA = "0x7BBCC81AC8")]
		public static bool operator !=(ResourceID a, ResourceID b)
		{
			return default(bool);
		}

		// Token: 0x06003C9A RID: 15514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C9A")]
		[Address(RVA = "0x11F24B8", Offset = "0x11F24B8", VA = "0x7BBB9F24B8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003C9B RID: 15515 RVA: 0x00012F30 File Offset: 0x00011130
		[Token(Token = "0x6003C9B")]
		[Address(RVA = "0x11F24E4", Offset = "0x11F24E4", VA = "0x7BBB9F24E4", Slot = "4")]
		public bool Equals(ResourceID other)
		{
			return default(bool);
		}

		// Token: 0x06003C9C RID: 15516 RVA: 0x00012F48 File Offset: 0x00011148
		[Token(Token = "0x6003C9C")]
		[Address(RVA = "0x11F24F4", Offset = "0x11F24F4", VA = "0x7BBB9F24F4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06003C9D RID: 15517 RVA: 0x00012F60 File Offset: 0x00011160
		[Token(Token = "0x6003C9D")]
		[Address(RVA = "0x11F24FC", Offset = "0x11F24FC", VA = "0x7BBB9F24FC", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04004DC1 RID: 19905
		[Token(Token = "0x4004DC1")]
		[FieldOffset(Offset = "0x0")]
		private readonly uint m_Value;

		// Token: 0x04004DC2 RID: 19906
		[Token(Token = "0x4004DC2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ResourceID INVALID;
	}
}
