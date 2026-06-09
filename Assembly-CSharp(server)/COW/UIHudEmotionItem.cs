using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C4D RID: 7245
	[Token(Token = "0x2001C4D")]
	internal class UIHudEmotionItem : MonoBehaviour
	{
		// Token: 0x06009D9D RID: 40349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D9D")]
		[Address(RVA = "0x1C02314", Offset = "0x1C02314", VA = "0x7BBC402314")]
		public void InitInfo(uint emotionID)
		{
		}

		// Token: 0x06009D9E RID: 40350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D9E")]
		[Address(RVA = "0x1C0307C", Offset = "0x1C0307C", VA = "0x7BBC40307C")]
		private void OnBtnEmotionClick()
		{
		}

		// Token: 0x06009D9F RID: 40351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D9F")]
		[Address(RVA = "0x1C03374", Offset = "0x1C03374", VA = "0x7BBC403374")]
		public UIHudEmotionItem()
		{
		}

		// Token: 0x0400A3C7 RID: 41927
		[Token(Token = "0x400A3C7")]
		[FieldOffset(Offset = "0x18")]
		public UIButton BtnEmotionItem;

		// Token: 0x0400A3C8 RID: 41928
		[Token(Token = "0x400A3C8")]
		[FieldOffset(Offset = "0x20")]
		public UISprite iconEmotionItem;

		// Token: 0x0400A3C9 RID: 41929
		[Token(Token = "0x400A3C9")]
		[FieldOffset(Offset = "0x28")]
		public Transform EmotionPos;

		// Token: 0x0400A3CA RID: 41930
		[Token(Token = "0x400A3CA")]
		[FieldOffset(Offset = "0x30")]
		private uint m_EmotionID;
	}
}
