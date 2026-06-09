using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001714 RID: 5908
	[Token(Token = "0x2001714")]
	internal class ClanAreaItemVO
	{
		// Token: 0x06006E2C RID: 28204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E2C")]
		[Address(RVA = "0x14F690C", Offset = "0x14F690C", VA = "0x7BBBCF690C")]
		public ClanAreaItemVO()
		{
		}

		// Token: 0x040088E5 RID: 35045
		[Token(Token = "0x40088E5")]
		[FieldOffset(Offset = "0x10")]
		public Transform m_Transform;

		// Token: 0x040088E6 RID: 35046
		[Token(Token = "0x40088E6")]
		[FieldOffset(Offset = "0x18")]
		public UIWidget m_Widget;

		// Token: 0x040088E7 RID: 35047
		[Token(Token = "0x40088E7")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 m_Offset;

		// Token: 0x040088E8 RID: 35048
		[Token(Token = "0x40088E8")]
		[FieldOffset(Offset = "0x30")]
		public object m_Data;
	}
}
