using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001984 RID: 6532
	[Token(Token = "0x2001984")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F66EC", Offset = "0x10F66EC")]
	internal class UIHudTriggerGrenadeController : UIBaseController
	{
		// Token: 0x0600852B RID: 34091 RVA: 0x000241E0 File Offset: 0x000223E0
		[Token(Token = "0x600852B")]
		[Address(RVA = "0x15EBF9C", Offset = "0x15EBF9C", VA = "0x7BBBDEBF9C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600852C RID: 34092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600852C")]
		[Address(RVA = "0x15EBFEC", Offset = "0x15EBFEC", VA = "0x7BBBDEBFEC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600852D RID: 34093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600852D")]
		[Address(RVA = "0x15EC2F0", Offset = "0x15EC2F0", VA = "0x7BBBDEC2F0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600852E RID: 34094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600852E")]
		[Address(RVA = "0x15EC3BC", Offset = "0x15EC3BC", VA = "0x7BBBDEC3BC")]
		private void OnBtnClick()
		{
		}

		// Token: 0x0600852F RID: 34095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600852F")]
		[Address(RVA = "0x15EC5F8", Offset = "0x15EC5F8", VA = "0x7BBBDEC5F8")]
		private void OnGrenadeTrigger()
		{
		}

		// Token: 0x06008530 RID: 34096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008530")]
		[Address(RVA = "0x15EC7A4", Offset = "0x15EC7A4", VA = "0x7BBBDEC7A4")]
		private void OnChangeVisible(params object[] param)
		{
		}

		// Token: 0x06008531 RID: 34097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008531")]
		[Address(RVA = "0x15ECA90", Offset = "0x15ECA90", VA = "0x7BBBDECA90")]
		private void Update()
		{
		}

		// Token: 0x06008532 RID: 34098 RVA: 0x000241F8 File Offset: 0x000223F8
		[Token(Token = "0x6008532")]
		[Address(RVA = "0x15ECEBC", Offset = "0x15ECEBC", VA = "0x7BBBDECEBC")]
		public float Progress()
		{
			return 0f;
		}

		// Token: 0x06008533 RID: 34099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008533")]
		[Address(RVA = "0x15EC164", Offset = "0x15EC164", VA = "0x7BBBDEC164")]
		private void ResetStatus()
		{
		}

		// Token: 0x06008534 RID: 34100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008534")]
		[Address(RVA = "0x15ECF94", Offset = "0x15ECF94", VA = "0x7BBBDECF94")]
		private void OnExecute()
		{
		}

		// Token: 0x06008535 RID: 34101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008535")]
		[Address(RVA = "0x15ECFD4", Offset = "0x15ECFD4", VA = "0x7BBBDECFD4")]
		public void SetDefaultPos(Vector3 pos)
		{
		}

		// Token: 0x06008536 RID: 34102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008536")]
		[Address(RVA = "0x15ECFE0", Offset = "0x15ECFE0", VA = "0x7BBBDECFE0")]
		public UIHudTriggerGrenadeController()
		{
		}

		// Token: 0x040094ED RID: 38125
		[Token(Token = "0x40094ED")]
		[FieldOffset(Offset = "0x58")]
		private UIHudTriggerGrenadeView m_View;

		// Token: 0x040094EE RID: 38126
		[Token(Token = "0x40094EE")]
		[FieldOffset(Offset = "0x60")]
		private float m_EndTime;

		// Token: 0x040094EF RID: 38127
		[Token(Token = "0x40094EF")]
		[FieldOffset(Offset = "0x64")]
		private float m_ExplosionTime;

		// Token: 0x040094F0 RID: 38128
		[Token(Token = "0x40094F0")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 m_pos;

		// Token: 0x040094F1 RID: 38129
		[Token(Token = "0x40094F1")]
		[FieldOffset(Offset = "0x74")]
		private ResourceID m_BeepSoundID;

		// Token: 0x040094F2 RID: 38130
		[Token(Token = "0x40094F2")]
		[FieldOffset(Offset = "0x78")]
		private AudioResource m_AudioSource;

		// Token: 0x040094F3 RID: 38131
		[Token(Token = "0x40094F3")]
		[FieldOffset(Offset = "0x80")]
		private Xh}Bpz] m_Grenade;

		// Token: 0x040094F4 RID: 38132
		[Token(Token = "0x40094F4")]
		[FieldOffset(Offset = "0x88")]
		private float m_LastRemainingTime;

		// Token: 0x040094F5 RID: 38133
		[Token(Token = "0x40094F5")]
		[FieldOffset(Offset = "0x8C")]
		private float m_LastProgress;

		// Token: 0x040094F6 RID: 38134
		[Token(Token = "0x40094F6")]
		[FieldOffset(Offset = "0x90")]
		private bool m_EnterDangerTime;
	}
}
