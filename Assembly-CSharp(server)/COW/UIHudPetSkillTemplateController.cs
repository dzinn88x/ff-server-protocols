using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020A3 RID: 8355
	[Token(Token = "0x20020A3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FDCBC", Offset = "0x10FDCBC")]
	public class UIHudPetSkillTemplateController : UIBaseController
	{
		// Token: 0x0600BBF4 RID: 48116 RVA: 0x00035280 File Offset: 0x00033480
		[Token(Token = "0x600BBF4")]
		[Address(RVA = "0x1D6F608", Offset = "0x1D6F608", VA = "0x7BBC56F608")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600BBF5 RID: 48117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBF5")]
		[Address(RVA = "0x1D6F658", Offset = "0x1D6F658", VA = "0x7BBC56F658", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600BBF6 RID: 48118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBF6")]
		[Address(RVA = "0x1D6F7A0", Offset = "0x1D6F7A0", VA = "0x7BBC56F7A0")]
		public void RefreshSkillData(PetSkillLevelData data)
		{
		}

		// Token: 0x0600BBF7 RID: 48119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBF7")]
		[Address(RVA = "0x1D6FA58", Offset = "0x1D6FA58", VA = "0x7BBC56FA58", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600BBF8 RID: 48120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBF8")]
		[Address(RVA = "0x1D6FA60", Offset = "0x1D6FA60", VA = "0x7BBC56FA60")]
		private void TryGetCameraComponent()
		{
		}

		// Token: 0x0600BBF9 RID: 48121 RVA: 0x00035298 File Offset: 0x00033498
		[Token(Token = "0x600BBF9")]
		[Address(RVA = "0x1D6FB44", Offset = "0x1D6FB44", VA = "0x7BBC56FB44")]
		private bool CheckPos(Vector2 pos)
		{
			return default(bool);
		}

		// Token: 0x0600BBFA RID: 48122 RVA: 0x000352B0 File Offset: 0x000334B0
		[Token(Token = "0x600BBFA")]
		[Address(RVA = "0x1D6FDFC", Offset = "0x1D6FDFC", VA = "0x7BBC56FDFC")]
		private bool CheckMobileTouch()
		{
			return default(bool);
		}

		// Token: 0x0600BBFB RID: 48123 RVA: 0x000352C8 File Offset: 0x000334C8
		[Token(Token = "0x600BBFB")]
		[Address(RVA = "0x1D6FEA0", Offset = "0x1D6FEA0", VA = "0x7BBC56FEA0")]
		private bool CheckPcTouch(Vector3 pos)
		{
			return default(bool);
		}

		// Token: 0x0600BBFC RID: 48124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBFC")]
		[Address(RVA = "0x1D6FF34", Offset = "0x1D6FF34", VA = "0x7BBC56FF34")]
		private void Update()
		{
		}

		// Token: 0x0600BBFD RID: 48125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBFD")]
		[Address(RVA = "0x1D700EC", Offset = "0x1D700EC", VA = "0x7BBC5700EC")]
		public UIHudPetSkillTemplateController()
		{
		}

		// Token: 0x0400BCA6 RID: 48294
		[Token(Token = "0x400BCA6")]
		[FieldOffset(Offset = "0x58")]
		private UIHudPetSkillTemplateView m_View;

		// Token: 0x0400BCA7 RID: 48295
		[Token(Token = "0x400BCA7")]
		[FieldOffset(Offset = "0x60")]
		private UICamera m_UICamera;

		// Token: 0x0400BCA8 RID: 48296
		[Token(Token = "0x400BCA8")]
		[FieldOffset(Offset = "0x68")]
		private Camera m_Camera;

		// Token: 0x0400BCA9 RID: 48297
		[Token(Token = "0x400BCA9")]
		[FieldOffset(Offset = "0x70")]
		private float dist;
	}
}
