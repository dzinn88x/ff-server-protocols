using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001868 RID: 6248
	[Token(Token = "0x2001868")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3FA4", Offset = "0x10F3FA4")]
	internal class UIHudActiveSkillController : UIHudButtonBaseController
	{
		// Token: 0x06007B2D RID: 31533 RVA: 0x00021E28 File Offset: 0x00020028
		[Token(Token = "0x6007B2D")]
		[Address(RVA = "0x1D69210", Offset = "0x1D69210", VA = "0x7BBC569210")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007B2E RID: 31534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B2E")]
		[Address(RVA = "0x1D69260", Offset = "0x1D69260", VA = "0x7BBC569260", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007B2F RID: 31535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B2F")]
		[Address(RVA = "0x1D697B0", Offset = "0x1D697B0", VA = "0x7BBC5697B0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007B30 RID: 31536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007B30")]
		[Address(RVA = "0x1D69AF0", Offset = "0x1D69AF0", VA = "0x7BBC569AF0", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06007B31 RID: 31537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B31")]
		[Address(RVA = "0x1D69B38", Offset = "0x1D69B38", VA = "0x7BBC569B38")]
		public void OnAddLocalPlayer(params object[] param)
		{
		}

		// Token: 0x06007B32 RID: 31538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B32")]
		[Address(RVA = "0x1D69D14", Offset = "0x1D69D14", VA = "0x7BBC569D14")]
		private void OnAddLocalPet(params object[] param)
		{
		}

		// Token: 0x06007B33 RID: 31539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B33")]
		[Address(RVA = "0x1D69DF8", Offset = "0x1D69DF8", VA = "0x7BBC569DF8")]
		private void OnChangActiveSkillState(params object[] param)
		{
		}

		// Token: 0x06007B34 RID: 31540 RVA: 0x00021E40 File Offset: 0x00020040
		[Token(Token = "0x6007B34")]
		[Address(RVA = "0x1D69EE8", Offset = "0x1D69EE8", VA = "0x7BBC569EE8")]
		public float BanSkillProgress()
		{
			return 0f;
		}

		// Token: 0x06007B35 RID: 31541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B35")]
		[Address(RVA = "0x1D69F6C", Offset = "0x1D69F6C", VA = "0x7BBC569F6C")]
		private void OnUpdateSkillIcon(params object[] param)
		{
		}

		// Token: 0x06007B36 RID: 31542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B36")]
		[Address(RVA = "0x1D69C38", Offset = "0x1D69C38", VA = "0x7BBC569C38")]
		protected void UpdateIcon()
		{
		}

		// Token: 0x06007B37 RID: 31543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B37")]
		[Address(RVA = "0x1D69F70", Offset = "0x1D69F70", VA = "0x7BBC569F70")]
		protected void Update()
		{
		}

		// Token: 0x06007B38 RID: 31544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B38")]
		[Address(RVA = "0x1D6A810", Offset = "0x1D6A810", VA = "0x7BBC56A810")]
		private void OnMiniPhaseChanged(params object[] data)
		{
		}

		// Token: 0x06007B39 RID: 31545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B39")]
		[Address(RVA = "0x1D6A5F8", Offset = "0x1D6A5F8", VA = "0x7BBC56A5F8")]
		private void ShowPetSkillAnim(bool show)
		{
		}

		// Token: 0x06007B3A RID: 31546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B3A")]
		[Address(RVA = "0x1D6A8A8", Offset = "0x1D6A8A8", VA = "0x7BBC56A8A8")]
		private void OnMiniGameStart(params object[] data)
		{
		}

		// Token: 0x06007B3B RID: 31547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B3B")]
		[Address(RVA = "0x1D6A958", Offset = "0x1D6A958", VA = "0x7BBC56A958")]
		private void OnMiniGameClose(params object[] data)
		{
		}

		// Token: 0x06007B3C RID: 31548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B3C")]
		[Address(RVA = "0x1D6A974", Offset = "0x1D6A974", VA = "0x7BBC56A974")]
		public UIHudActiveSkillController()
		{
		}

		// Token: 0x04008FCB RID: 36811
		[Token(Token = "0x4008FCB")]
		[FieldOffset(Offset = "0x60")]
		private UIHudActiveSkillView m_View;

		// Token: 0x04008FCC RID: 36812
		[Token(Token = "0x4008FCC")]
		[FieldOffset(Offset = "0x68")]
		private b]LTXBp m_ActiveSkill;

		// Token: 0x04008FCD RID: 36813
		[Token(Token = "0x4008FCD")]
		[FieldOffset(Offset = "0x70")]
		private NetworkPet m_LocalPet;

		// Token: 0x04008FCE RID: 36814
		[Token(Token = "0x4008FCE")]
		[FieldOffset(Offset = "0x78")]
		private float m_BanSkillTime;

		// Token: 0x04008FCF RID: 36815
		[Token(Token = "0x4008FCF")]
		[FieldOffset(Offset = "0x7C")]
		private float m_StartBanTime;

		// Token: 0x04008FD0 RID: 36816
		[Token(Token = "0x4008FD0")]
		[FieldOffset(Offset = "0x80")]
		private float m_TakeEffectTime;

		// Token: 0x04008FD1 RID: 36817
		[Token(Token = "0x4008FD1")]
		[FieldOffset(Offset = "0x88")]
		private List<GameObject> m_PetSkillAnimationGameObject;

		// Token: 0x04008FD2 RID: 36818
		[Token(Token = "0x4008FD2")]
		[FieldOffset(Offset = "0x90")]
		private bool m_IsLastInCD;
	}
}
