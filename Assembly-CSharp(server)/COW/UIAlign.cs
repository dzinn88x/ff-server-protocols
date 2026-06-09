using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C97 RID: 7319
	[Token(Token = "0x2001C97")]
	public class UIAlign : MonoBehaviour
	{
		// Token: 0x06009FB9 RID: 40889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FB9")]
		[Address(RVA = "0x19698DC", Offset = "0x19698DC", VA = "0x7BBC1698DC")]
		public void Refresh(float width, float height)
		{
		}

		// Token: 0x06009FBA RID: 40890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FBA")]
		[Address(RVA = "0x1969974", Offset = "0x1969974", VA = "0x7BBC169974")]
		public UIAlign()
		{
		}

		// Token: 0x0400A677 RID: 42615
		[Token(Token = "0x400A677")]
		[FieldOffset(Offset = "0x18")]
		public UIAlign.EAlign m_Align;

		// Token: 0x02001C98 RID: 7320
		[Token(Token = "0x2001C98")]
		public enum EAlign
		{
			// Token: 0x0400A679 RID: 42617
			[Token(Token = "0x400A679")]
			Bottom
		}
	}
}
