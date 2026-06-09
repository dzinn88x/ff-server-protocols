using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C2A RID: 7210
	[Token(Token = "0x2001C2A")]
	public class CustomHudItem : MonoBehaviour
	{
		// Token: 0x06009CE8 RID: 40168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CE8")]
		[Address(RVA = "0x1600994", Offset = "0x1600994", VA = "0x7BBBE00994")]
		protected void Awake()
		{
		}

		// Token: 0x06009CE9 RID: 40169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CE9")]
		[Address(RVA = "0x1600AF8", Offset = "0x1600AF8", VA = "0x7BBBE00AF8", Slot = "4")]
		protected virtual void OnHudPress(GameObject go, bool state)
		{
		}

		// Token: 0x06009CEA RID: 40170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CEA")]
		[Address(RVA = "0x1600C4C", Offset = "0x1600C4C", VA = "0x7BBBE00C4C", Slot = "5")]
		protected virtual void OnHudDragStart(GameObject go)
		{
		}

		// Token: 0x06009CEB RID: 40171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CEB")]
		[Address(RVA = "0x1600C50", Offset = "0x1600C50", VA = "0x7BBBE00C50", Slot = "6")]
		protected virtual void OnHudDragEnd(GameObject go)
		{
		}

		// Token: 0x06009CEC RID: 40172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CEC")]
		[Address(RVA = "0x1600DA4", Offset = "0x1600DA4", VA = "0x7BBBE00DA4")]
		public CustomHudItem()
		{
		}

		// Token: 0x0400A2E7 RID: 41703
		[Token(Token = "0x400A2E7")]
		[FieldOffset(Offset = "0x18")]
		public UIEventListener m_EventListener;

		// Token: 0x0400A2E8 RID: 41704
		[Token(Token = "0x400A2E8")]
		[FieldOffset(Offset = "0x20")]
		public string m_HudName;

		// Token: 0x0400A2E9 RID: 41705
		[Token(Token = "0x400A2E9")]
		[FieldOffset(Offset = "0x28")]
		public UISprite m_LockIcon;

		// Token: 0x0400A2EA RID: 41706
		[Token(Token = "0x400A2EA")]
		[FieldOffset(Offset = "0x30")]
		public UISprite m_Hidden;

		// Token: 0x0400A2EB RID: 41707
		[Token(Token = "0x400A2EB")]
		[FieldOffset(Offset = "0x38")]
		public UIWidget m_BG;

		// Token: 0x0400A2EC RID: 41708
		[Token(Token = "0x400A2EC")]
		[FieldOffset(Offset = "0x40")]
		public bool m_Circle;
	}
}
