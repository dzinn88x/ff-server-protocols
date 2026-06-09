using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C59 RID: 7257
	[Token(Token = "0x2001C59")]
	public class SoundTipsView : MonoBehaviour
	{
		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06009DF9 RID: 40441 RVA: 0x00029520 File Offset: 0x00027720
		[Token(Token = "0x17000A6E")]
		public bool IsInDelayStop
		{
			[Token(Token = "0x6009DF9")]
			[Address(RVA = "0x1B3AD40", Offset = "0x1B3AD40", VA = "0x7BBC33AD40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06009DFA RID: 40442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DFA")]
		[Address(RVA = "0x1B3AD50", Offset = "0x1B3AD50", VA = "0x7BBC33AD50")]
		public void SoundTipInit(ESoundTipsType type)
		{
		}

		// Token: 0x06009DFB RID: 40443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DFB")]
		[Address(RVA = "0x1B3AF44", Offset = "0x1B3AF44", VA = "0x7BBC33AF44")]
		public void StartSoundTip()
		{
		}

		// Token: 0x06009DFC RID: 40444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DFC")]
		[Address(RVA = "0x1B3AFC0", Offset = "0x1B3AFC0", VA = "0x7BBC33AFC0")]
		public void DelayStopSoundTip(float waitTime)
		{
		}

		// Token: 0x06009DFD RID: 40445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DFD")]
		[Address(RVA = "0x1B3B0BC", Offset = "0x1B3B0BC", VA = "0x7BBC33B0BC")]
		public void SetSoundTipColor(Color _color)
		{
		}

		// Token: 0x06009DFE RID: 40446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DFE")]
		[Address(RVA = "0x1B3B1B0", Offset = "0x1B3B1B0", VA = "0x7BBC33B1B0")]
		public void StopSoundTip()
		{
		}

		// Token: 0x06009DFF RID: 40447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DFF")]
		[Address(RVA = "0x1B3B218", Offset = "0x1B3B218", VA = "0x7BBC33B218")]
		private void LateUpdate()
		{
		}

		// Token: 0x06009E00 RID: 40448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E00")]
		[Address(RVA = "0x1B3B2E8", Offset = "0x1B3B2E8", VA = "0x7BBC33B2E8")]
		public SoundTipsView()
		{
		}

		// Token: 0x0400A42F RID: 42031
		[Token(Token = "0x400A42F")]
		[FieldOffset(Offset = "0x18")]
		public UISprite SpriteVehicleSoundTip;

		// Token: 0x0400A430 RID: 42032
		[Token(Token = "0x400A430")]
		[FieldOffset(Offset = "0x20")]
		public UISprite SpriteFootStepSoundTip;

		// Token: 0x0400A431 RID: 42033
		[Token(Token = "0x400A431")]
		[FieldOffset(Offset = "0x28")]
		public UISprite SpriteFireSoundTip;

		// Token: 0x0400A432 RID: 42034
		[Token(Token = "0x400A432")]
		[FieldOffset(Offset = "0x30")]
		public TweenAlpha SoundTipTween;

		// Token: 0x0400A433 RID: 42035
		[Token(Token = "0x400A433")]
		[FieldOffset(Offset = "0x38")]
		public Color WarningTipColor;

		// Token: 0x0400A434 RID: 42036
		[Token(Token = "0x400A434")]
		[FieldOffset(Offset = "0x48")]
		public Color DangerTipColor;

		// Token: 0x0400A435 RID: 42037
		[Token(Token = "0x400A435")]
		[FieldOffset(Offset = "0x58")]
		private UISprite m_SoundTipSprite;

		// Token: 0x0400A436 RID: 42038
		[Token(Token = "0x400A436")]
		[FieldOffset(Offset = "0x60")]
		private Timer m_DelayStopTimer;
	}
}
