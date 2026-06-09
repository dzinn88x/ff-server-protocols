using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001AAE RID: 6830
	[Token(Token = "0x2001AAE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F88C4", Offset = "0x10F88C4")]
	internal class UIOBPlayerNamePlateController : UIBaseController
	{
		// Token: 0x06009005 RID: 36869 RVA: 0x00026658 File Offset: 0x00024858
		[Token(Token = "0x6009005")]
		[Address(RVA = "0x1B0B874", Offset = "0x1B0B874", VA = "0x7BBC30B874")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009006 RID: 36870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009006")]
		[Address(RVA = "0x1B0B8C4", Offset = "0x1B0B8C4", VA = "0x7BBC30B8C4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009007 RID: 36871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009007")]
		[Address(RVA = "0x1B0BEC4", Offset = "0x1B0BEC4", VA = "0x7BBC30BEC4")]
		public void InitDepth(int name_plate_depth)
		{
		}

		// Token: 0x06009008 RID: 36872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009008")]
		[Address(RVA = "0x1B0BECC", Offset = "0x1B0BECC", VA = "0x7BBC30BECC")]
		private void SetDepth(int name_plate_depth)
		{
		}

		// Token: 0x06009009 RID: 36873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009009")]
		[Address(RVA = "0x1B0C230", Offset = "0x1B0C230", VA = "0x7BBC30C230")]
		public void BindPlayerData(PlayerData data, bool EnableGoto)
		{
		}

		// Token: 0x0600900A RID: 36874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600900A")]
		[Address(RVA = "0x1B0C6BC", Offset = "0x1B0C6BC", VA = "0x7BBC30C6BC")]
		public void UpdatePlayerInfo(bool needName = true)
		{
		}

		// Token: 0x0600900B RID: 36875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600900B")]
		[Address(RVA = "0x1B0C9DC", Offset = "0x1B0C9DC", VA = "0x7BBC30C9DC")]
		public void PlayHurtEffect()
		{
		}

		// Token: 0x0600900C RID: 36876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600900C")]
		[Address(RVA = "0x1B0CB40", Offset = "0x1B0CB40", VA = "0x7BBC30CB40")]
		public void FireEffectVisibleChange(bool isVisible)
		{
		}

		// Token: 0x0600900D RID: 36877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600900D")]
		[Address(RVA = "0x1B0CBA0", Offset = "0x1B0CBA0", VA = "0x7BBC30CBA0")]
		public void DrawFiringRay(float scale)
		{
		}

		// Token: 0x0600900E RID: 36878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600900E")]
		[Address(RVA = "0x1B0CEFC", Offset = "0x1B0CEFC", VA = "0x7BBC30CEFC")]
		public void SwithPlayerState(EOBPlayerStateType next_state_type)
		{
		}

		// Token: 0x0600900F RID: 36879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600900F")]
		[Address(RVA = "0x1B0D068", Offset = "0x1B0D068", VA = "0x7BBC30D068")]
		public void UpdatePlayerRotation()
		{
		}

		// Token: 0x06009010 RID: 36880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009010")]
		[Address(RVA = "0x1B0D24C", Offset = "0x1B0D24C", VA = "0x7BBC30D24C")]
		public void UpdateNamePlateRotaion(float angle)
		{
		}

		// Token: 0x06009011 RID: 36881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009011")]
		[Address(RVA = "0x1B0D3C0", Offset = "0x1B0D3C0", VA = "0x7BBC30D3C0")]
		public void UpdatePlayerPosition()
		{
		}

		// Token: 0x06009012 RID: 36882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009012")]
		[Address(RVA = "0x1B0D580", Offset = "0x1B0D580", VA = "0x7BBC30D580")]
		public void ToggleNameplateName(bool visible)
		{
		}

		// Token: 0x06009013 RID: 36883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009013")]
		[Address(RVA = "0x1B0D5C8", Offset = "0x1B0D5C8", VA = "0x7BBC30D5C8")]
		private void OnGotoBtnClcik()
		{
		}

		// Token: 0x06009014 RID: 36884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009014")]
		[Address(RVA = "0x1B0D678", Offset = "0x1B0D678", VA = "0x7BBC30D678", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009015 RID: 36885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009015")]
		[Address(RVA = "0x1B0D800", Offset = "0x1B0D800", VA = "0x7BBC30D800")]
		private void OnToggleShowTeamIcon(object[] data)
		{
		}

		// Token: 0x06009016 RID: 36886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009016")]
		[Address(RVA = "0x1B0D8A0", Offset = "0x1B0D8A0", VA = "0x7BBC30D8A0")]
		private void OnShowKok(params object[] data)
		{
		}

		// Token: 0x06009017 RID: 36887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009017")]
		[Address(RVA = "0x1B0C4D4", Offset = "0x1B0C4D4", VA = "0x7BBC30C4D4")]
		private void ShowTeamIcon(bool show)
		{
		}

		// Token: 0x06009018 RID: 36888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009018")]
		[Address(RVA = "0x1B0D9C8", Offset = "0x1B0D9C8", VA = "0x7BBC30D9C8")]
		public UIOBPlayerNamePlateController()
		{
		}

		// Token: 0x06009019 RID: 36889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009019")]
		[Address(RVA = "0x1B0DA38", Offset = "0x1B0DA38", VA = "0x7BBC30DA38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144838", Offset = "0x1144838")]
		private void <PlayHurtEffect>b__15_0()
		{
		}

		// Token: 0x0600901A RID: 36890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600901A")]
		[Address(RVA = "0x1B0DA90", Offset = "0x1B0DA90", VA = "0x7BBC30DA90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144848", Offset = "0x1144848")]
		private void <DrawFiringRay>b__17_0()
		{
		}

		// Token: 0x04009BEC RID: 39916
		[Token(Token = "0x4009BEC")]
		[FieldOffset(Offset = "0x58")]
		private UIOBPlayerNamePlateView m_View;

		// Token: 0x04009BED RID: 39917
		[Token(Token = "0x4009BED")]
		[FieldOffset(Offset = "0x60")]
		private OBPlayerState_Base m_CurState;

		// Token: 0x04009BEE RID: 39918
		[Token(Token = "0x4009BEE")]
		[FieldOffset(Offset = "0x68")]
		private PlayerData m_PlayerData;

		// Token: 0x04009BEF RID: 39919
		[Token(Token = "0x4009BEF")]
		[FieldOffset(Offset = "0x70")]
		private bool m_EnableGoto;

		// Token: 0x04009BF0 RID: 39920
		[Token(Token = "0x4009BF0")]
		[FieldOffset(Offset = "0x74")]
		private uint m_FiringRayDelayCall;

		// Token: 0x04009BF1 RID: 39921
		[Token(Token = "0x4009BF1")]
		[FieldOffset(Offset = "0x78")]
		private int m_CurrentDepth;

		// Token: 0x04009BF2 RID: 39922
		[Token(Token = "0x4009BF2")]
		private const int MAXDEPTH = 500;

		// Token: 0x04009BF3 RID: 39923
		[Token(Token = "0x4009BF3")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<EOBPlayerStateType, OBPlayerState_Base> m_OBStateCache;

		// Token: 0x04009BF4 RID: 39924
		[Token(Token = "0x4009BF4")]
		[FieldOffset(Offset = "0x88")]
		private uint m_HurtDelayCallID;
	}
}
