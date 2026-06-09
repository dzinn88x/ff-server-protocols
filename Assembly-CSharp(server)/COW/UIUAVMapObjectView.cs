using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025C7 RID: 9671
	[Token(Token = "0x20025C7")]
	public class UIUAVMapObjectView : MonoBehaviour
	{
		// Token: 0x0600C6C8 RID: 50888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6C8")]
		[Address(RVA = "0x19FAFC0", Offset = "0x19FAFC0", VA = "0x7BBC1FAFC0")]
		public UIUAVMapObjectView()
		{
		}

		// Token: 0x0400F948 RID: 63816
		[Token(Token = "0x400F948")]
		[FieldOffset(Offset = "0x18")]
		public Transform UAVTemplate;

		// Token: 0x0400F949 RID: 63817
		[Token(Token = "0x400F949")]
		[FieldOffset(Offset = "0x20")]
		public UISprite uavCircle;

		// Token: 0x0400F94A RID: 63818
		[Token(Token = "0x400F94A")]
		[FieldOffset(Offset = "0x28")]
		public TweenScale uavCircleLine;

		// Token: 0x0400F94B RID: 63819
		[Token(Token = "0x400F94B")]
		[FieldOffset(Offset = "0x30")]
		public UISprite uavIcon;
	}
}
