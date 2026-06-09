using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001925 RID: 6437
	[Token(Token = "0x2001925")]
	public class UIHudPetSkillBufferController : UIBaseController
	{
		// Token: 0x06008202 RID: 33282 RVA: 0x000236A0 File Offset: 0x000218A0
		[Token(Token = "0x6008202")]
		[Address(RVA = "0x1D6ECA8", Offset = "0x1D6ECA8", VA = "0x7BBC56ECA8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008203 RID: 33283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008203")]
		[Address(RVA = "0x1D6ECF8", Offset = "0x1D6ECF8", VA = "0x7BBC56ECF8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008204 RID: 33284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008204")]
		[Address(RVA = "0x1D6EE3C", Offset = "0x1D6EE3C", VA = "0x7BBC56EE3C", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06008205 RID: 33285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008205")]
		[Address(RVA = "0x1D6EF08", Offset = "0x1D6EF08", VA = "0x7BBC56EF08")]
		public void SkillStart(uint petID, uint petSkillID, uint petSkillLevel, Action closeCallback)
		{
		}

		// Token: 0x06008206 RID: 33286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008206")]
		[Address(RVA = "0x1D6F288", Offset = "0x1D6F288", VA = "0x7BBC56F288")]
		private void OnPetSkillEnd(params object[] param)
		{
		}

		// Token: 0x06008207 RID: 33287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008207")]
		[Address(RVA = "0x1D6F2C8", Offset = "0x1D6F2C8", VA = "0x7BBC56F2C8")]
		private void Update()
		{
		}

		// Token: 0x06008208 RID: 33288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008208")]
		[Address(RVA = "0x1D6F28C", Offset = "0x1D6F28C", VA = "0x7BBC56F28C")]
		private void CloseUI()
		{
		}

		// Token: 0x06008209 RID: 33289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008209")]
		[Address(RVA = "0x1D6F45C", Offset = "0x1D6F45C", VA = "0x7BBC56F45C")]
		public UIHudPetSkillBufferController()
		{
		}

		// Token: 0x04009368 RID: 37736
		[Token(Token = "0x4009368")]
		[FieldOffset(Offset = "0x58")]
		private UIHudPetSkillBufferView m_View;

		// Token: 0x04009369 RID: 37737
		[Token(Token = "0x4009369")]
		[FieldOffset(Offset = "0x60")]
		private uint m_PetSkillID;

		// Token: 0x0400936A RID: 37738
		[Token(Token = "0x400936A")]
		[FieldOffset(Offset = "0x64")]
		private uint m_PetSkillLevel;

		// Token: 0x0400936B RID: 37739
		[Token(Token = "0x400936B")]
		[FieldOffset(Offset = "0x68")]
		private PetSkillLevelData m_SkillLevelData;

		// Token: 0x0400936C RID: 37740
		[Token(Token = "0x400936C")]
		[FieldOffset(Offset = "0x70")]
		private Action m_OnCloseCallback;

		// Token: 0x0400936D RID: 37741
		[Token(Token = "0x400936D")]
		[FieldOffset(Offset = "0x78")]
		private float m_lastTime;

		// Token: 0x0400936E RID: 37742
		[Token(Token = "0x400936E")]
		[FieldOffset(Offset = "0x7C")]
		private float m_CDTime;
	}
}
