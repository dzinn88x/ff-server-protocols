using System;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001433 RID: 5171
	[Token(Token = "0x2001433")]
	public class UIAvatarAwakenStoryItemController : MonoBehaviour
	{
		// Token: 0x060055BD RID: 21949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055BD")]
		[Address(RVA = "0x1B1F954", Offset = "0x1B1F954", VA = "0x7BBC31F954")]
		private void Awake()
		{
		}

		// Token: 0x060055BE RID: 21950 RVA: 0x00019860 File Offset: 0x00017A60
		[Token(Token = "0x60055BE")]
		[Address(RVA = "0x1B1A780", Offset = "0x1B1A780", VA = "0x7BBC31A780")]
		public StoryShowState GetCurShowState()
		{
			return StoryShowState.Lock;
		}

		// Token: 0x060055BF RID: 21951 RVA: 0x00019878 File Offset: 0x00017A78
		[Token(Token = "0x60055BF")]
		[Address(RVA = "0x1B1A788", Offset = "0x1B1A788", VA = "0x7BBC31A788")]
		public bool CanCurrentStateUnlock()
		{
			return default(bool);
		}

		// Token: 0x060055C0 RID: 21952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055C0")]
		[Address(RVA = "0x1B1A694", Offset = "0x1B1A694", VA = "0x7BBC31A694")]
		public void RefreshData()
		{
		}

		// Token: 0x060055C1 RID: 21953 RVA: 0x00019890 File Offset: 0x00017A90
		[Token(Token = "0x60055C1")]
		[Address(RVA = "0x1B1FBAC", Offset = "0x1B1FBAC", VA = "0x7BBC31FBAC")]
		private StoryShowState GetCurrentShowState(AwakenComic comicInfoBefore, AwakenComic comicInfoCur)
		{
			return StoryShowState.Lock;
		}

		// Token: 0x060055C2 RID: 21954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055C2")]
		[Address(RVA = "0x1B19ED8", Offset = "0x1B19ED8", VA = "0x7BBC319ED8")]
		public void SetCDNInfo(AvatarAwakenComicData comicData)
		{
		}

		// Token: 0x060055C3 RID: 21955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055C3")]
		[Address(RVA = "0x1B1FEF4", Offset = "0x1B1FEF4", VA = "0x7BBC31FEF4")]
		private void OnPlayButtonClick()
		{
		}

		// Token: 0x060055C4 RID: 21956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055C4")]
		[Address(RVA = "0x1B20218", Offset = "0x1B20218", VA = "0x7BBC320218")]
		private void OnUnlockButtonClick_1()
		{
		}

		// Token: 0x060055C5 RID: 21957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055C5")]
		[Address(RVA = "0x1B204B0", Offset = "0x1B204B0", VA = "0x7BBC3204B0")]
		private void OnUnlockButtonClick_2()
		{
		}

		// Token: 0x060055C6 RID: 21958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055C6")]
		[Address(RVA = "0x1B204C4", Offset = "0x1B204C4", VA = "0x7BBC3204C4")]
		private void OnUnlockButtonClick_3()
		{
		}

		// Token: 0x060055C7 RID: 21959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055C7")]
		[Address(RVA = "0x1B2022C", Offset = "0x1B2022C", VA = "0x7BBC32022C")]
		private void OnUnlockButtonClick()
		{
		}

		// Token: 0x060055C8 RID: 21960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055C8")]
		[Address(RVA = "0x1B1FC4C", Offset = "0x1B1FC4C", VA = "0x7BBC31FC4C")]
		private void UpdateAwakenItem()
		{
		}

		// Token: 0x060055C9 RID: 21961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055C9")]
		[Address(RVA = "0x1B1FC48", Offset = "0x1B1FC48", VA = "0x7BBC31FC48")]
		private void UpdateButtonState(StoryShowState state)
		{
		}

		// Token: 0x060055CA RID: 21962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055CA")]
		[Address(RVA = "0x1B204D8", Offset = "0x1B204D8", VA = "0x7BBC3204D8")]
		private void SetShowState(StoryShowState state)
		{
		}

		// Token: 0x060055CB RID: 21963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055CB")]
		[Address(RVA = "0x1B1FEB0", Offset = "0x1B1FEB0", VA = "0x7BBC31FEB0")]
		private void SetCDN(UINetworkTextureExt cdn, string url)
		{
		}

		// Token: 0x060055CC RID: 21964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055CC")]
		[Address(RVA = "0x1B20C28", Offset = "0x1B20C28", VA = "0x7BBC320C28")]
		public UIAvatarAwakenStoryItemController()
		{
		}

		// Token: 0x04007A7D RID: 31357
		[Token(Token = "0x4007A7D")]
		[FieldOffset(Offset = "0x18")]
		private AvatarAwakenComicData m_Data;

		// Token: 0x04007A7E RID: 31358
		[Token(Token = "0x4007A7E")]
		[FieldOffset(Offset = "0x20")]
		public UIButton PlayButton;

		// Token: 0x04007A7F RID: 31359
		[Token(Token = "0x4007A7F")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Desc;

		// Token: 0x04007A80 RID: 31360
		[Token(Token = "0x4007A80")]
		[FieldOffset(Offset = "0x30")]
		private uint m_StoryId;

		// Token: 0x04007A81 RID: 31361
		[Token(Token = "0x4007A81")]
		[FieldOffset(Offset = "0x38")]
		private UIModelAvatarProfile m_Model;

		// Token: 0x04007A82 RID: 31362
		[Token(Token = "0x4007A82")]
		[FieldOffset(Offset = "0x40")]
		public UINetworkTextureExt CDNIMG;

		// Token: 0x04007A83 RID: 31363
		[Token(Token = "0x4007A83")]
		[FieldOffset(Offset = "0x48")]
		public GameObject LockGroup;

		// Token: 0x04007A84 RID: 31364
		[Token(Token = "0x4007A84")]
		[FieldOffset(Offset = "0x50")]
		public GameObject LockAll;

		// Token: 0x04007A85 RID: 31365
		[Token(Token = "0x4007A85")]
		[FieldOffset(Offset = "0x58")]
		public GameObject LockComponent;

		// Token: 0x04007A86 RID: 31366
		[Token(Token = "0x4007A86")]
		[FieldOffset(Offset = "0x60")]
		public GameObject LockPos1;

		// Token: 0x04007A87 RID: 31367
		[Token(Token = "0x4007A87")]
		[FieldOffset(Offset = "0x68")]
		public GameObject LockPos2;

		// Token: 0x04007A88 RID: 31368
		[Token(Token = "0x4007A88")]
		[FieldOffset(Offset = "0x70")]
		public GameObject LockPos3;

		// Token: 0x04007A89 RID: 31369
		[Token(Token = "0x4007A89")]
		[FieldOffset(Offset = "0x78")]
		public GameObject LockIcon1;

		// Token: 0x04007A8A RID: 31370
		[Token(Token = "0x4007A8A")]
		[FieldOffset(Offset = "0x80")]
		public GameObject LockIcon2;

		// Token: 0x04007A8B RID: 31371
		[Token(Token = "0x4007A8B")]
		[FieldOffset(Offset = "0x88")]
		public GameObject LockIcon3;

		// Token: 0x04007A8C RID: 31372
		[Token(Token = "0x4007A8C")]
		[FieldOffset(Offset = "0x90")]
		public UILabel LockProgress;

		// Token: 0x04007A8D RID: 31373
		[Token(Token = "0x4007A8D")]
		[FieldOffset(Offset = "0x98")]
		public UISprite AwakenItemIcon;

		// Token: 0x04007A8E RID: 31374
		[Token(Token = "0x4007A8E")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton LockBtn1;

		// Token: 0x04007A8F RID: 31375
		[Token(Token = "0x4007A8F")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton LockBtn2;

		// Token: 0x04007A90 RID: 31376
		[Token(Token = "0x4007A90")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton LockBtn3;

		// Token: 0x04007A91 RID: 31377
		[Token(Token = "0x4007A91")]
		[FieldOffset(Offset = "0xB8")]
		public Animator effectAnim;

		// Token: 0x04007A92 RID: 31378
		[Token(Token = "0x4007A92")]
		[FieldOffset(Offset = "0xC0")]
		private StoryShowState m_CurrentState;
	}
}
