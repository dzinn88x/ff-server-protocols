using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200208B RID: 8331
	[Token(Token = "0x200208B")]
	internal class UIReaperGameScene : UIInGameScene
	{
		// Token: 0x0600BAF6 RID: 47862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAF6")]
		[Address(RVA = "0x1E11D38", Offset = "0x1E11D38", VA = "0x7BBC611D38", Slot = "8")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600BAF7 RID: 47863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAF7")]
		[Address(RVA = "0x1E11D40", Offset = "0x1E11D40", VA = "0x7BBC611D40", Slot = "12")]
		protected override void OpenCommonHud()
		{
		}

		// Token: 0x0600BAF8 RID: 47864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAF8")]
		[Address(RVA = "0x1E11E60", Offset = "0x1E11E60", VA = "0x7BBC611E60", Slot = "10")]
		public override void RegisterGameEventHandler()
		{
		}

		// Token: 0x0600BAF9 RID: 47865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAF9")]
		[Address(RVA = "0x1E11F2C", Offset = "0x1E11F2C", VA = "0x7BBC611F2C", Slot = "9")]
		protected override void OnDestory()
		{
		}

		// Token: 0x0600BAFA RID: 47866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAFA")]
		[Address(RVA = "0x1E11FF8", Offset = "0x1E11FF8", VA = "0x7BBC611FF8")]
		public void OnEnterPregame()
		{
		}

		// Token: 0x0600BAFB RID: 47867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAFB")]
		[Address(RVA = "0x1E121EC", Offset = "0x1E121EC", VA = "0x7BBC6121EC")]
		public void OnEnterFight()
		{
		}

		// Token: 0x0600BAFC RID: 47868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAFC")]
		[Address(RVA = "0x1E125A4", Offset = "0x1E125A4", VA = "0x7BBC6125A4")]
		public void OnIntroEnd()
		{
		}

		// Token: 0x0600BAFD RID: 47869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAFD")]
		[Address(RVA = "0x1E125A8", Offset = "0x1E125A8", VA = "0x7BBC6125A8")]
		public void OnFirstSecondScoreChange()
		{
		}

		// Token: 0x0600BAFE RID: 47870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAFE")]
		[Address(RVA = "0x1E1276C", Offset = "0x1E1276C", VA = "0x7BBC61276C")]
		public void OnSoulChange()
		{
		}

		// Token: 0x0600BAFF RID: 47871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAFF")]
		[Address(RVA = "0x1E1279C", Offset = "0x1E1279C", VA = "0x7BBC61279C")]
		public void OnReaperHPChange(int oldV, int newV)
		{
		}

		// Token: 0x0600BB00 RID: 47872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB00")]
		[Address(RVA = "0x1E12854", Offset = "0x1E12854", VA = "0x7BBC612854")]
		public void OnReaperStateChange(bool toReaper = false, bool toNormal = false)
		{
		}

		// Token: 0x0600BB01 RID: 47873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB01")]
		[Address(RVA = "0x1E12510", Offset = "0x1E12510", VA = "0x7BBC612510")]
		public void OpenEquipSetSelection()
		{
		}

		// Token: 0x0600BB02 RID: 47874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BB02")]
		[Address(RVA = "0x1E129EC", Offset = "0x1E129EC", VA = "0x7BBC6129EC", Slot = "14")]
		protected override Type GetMatchResultType()
		{
			return null;
		}

		// Token: 0x0600BB03 RID: 47875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB03")]
		[Address(RVA = "0x1E12A5C", Offset = "0x1E12A5C", VA = "0x7BBC612A5C")]
		public UIReaperGameScene()
		{
		}

		// Token: 0x0600BB04 RID: 47876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB04")]
		[Address(RVA = "0x1E12AC4", Offset = "0x1E12AC4", VA = "0x7BBC612AC4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147CA4", Offset = "0x1147CA4")]
		private void <OnEnterPregame>b__7_0()
		{
		}

		// Token: 0x0400BC32 RID: 48178
		[Token(Token = "0x400BC32")]
		[FieldOffset(Offset = "0x3D0")]
		private UIHudReaperProgressBarController m_ScoreProgressBar;

		// Token: 0x0400BC33 RID: 48179
		[Token(Token = "0x400BC33")]
		[FieldOffset(Offset = "0x3D8")]
		private UIHudReaperTransformController m_ReaperTransformBtn;

		// Token: 0x0400BC34 RID: 48180
		[Token(Token = "0x400BC34")]
		[FieldOffset(Offset = "0x3E0")]
		private UIHudReaperHPBarController m_ReaperHPBar;
	}
}
