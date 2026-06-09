using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021C5 RID: 8645
	[Token(Token = "0x20021C5")]
	public class UIEmoteShowItemView : MonoBehaviour
	{
		// Token: 0x0600BE9A RID: 48794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE9A")]
		[Address(RVA = "0x1E77144", Offset = "0x1E77144", VA = "0x7BBC677144")]
		public void SetData(uint eid)
		{
		}

		// Token: 0x0600BE9B RID: 48795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE9B")]
		[Address(RVA = "0x1E773A0", Offset = "0x1E773A0", VA = "0x7BBC6773A0")]
		private void OnEmoteItemClick()
		{
		}

		// Token: 0x0600BE9C RID: 48796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE9C")]
		[Address(RVA = "0x1E7750C", Offset = "0x1E7750C", VA = "0x7BBC67750C")]
		public UIEmoteShowItemView()
		{
		}

		// Token: 0x0400CB02 RID: 51970
		[Token(Token = "0x400CB02")]
		[FieldOffset(Offset = "0x18")]
		public UIButton EmoteItemBtn;

		// Token: 0x0400CB03 RID: 51971
		[Token(Token = "0x400CB03")]
		[FieldOffset(Offset = "0x20")]
		public UISprite EmoteItemSpr;

		// Token: 0x0400CB04 RID: 51972
		[Token(Token = "0x400CB04")]
		[FieldOffset(Offset = "0x28")]
		public UISprite booyahEmotionSpr;

		// Token: 0x0400CB05 RID: 51973
		[Token(Token = "0x400CB05")]
		[FieldOffset(Offset = "0x30")]
		public Transform EmotionPos;

		// Token: 0x0400CB06 RID: 51974
		[Token(Token = "0x400CB06")]
		[FieldOffset(Offset = "0x38")]
		private uint m_EmoteID;
	}
}
