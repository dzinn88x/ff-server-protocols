using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023FA RID: 9210
	[Token(Token = "0x20023FA")]
	public class UILobbyInventoryNewView : UIBaseView
	{
		// Token: 0x0600C304 RID: 49924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C304")]
		[Address(RVA = "0x143E56C", Offset = "0x143E56C", VA = "0x7BBBC3E56C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C305 RID: 49925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C305")]
		[Address(RVA = "0x143F91C", Offset = "0x143F91C", VA = "0x7BBBC3F91C")]
		public UILobbyInventoryNewView()
		{
		}

		// Token: 0x0400E1CB RID: 57803
		[Token(Token = "0x400E1CB")]
		[FieldOffset(Offset = "0x20")]
		public UITexture BG;

		// Token: 0x0400E1CC RID: 57804
		[Token(Token = "0x400E1CC")]
		[FieldOffset(Offset = "0x28")]
		public GameObject GoLegendColor;

		// Token: 0x0400E1CD RID: 57805
		[Token(Token = "0x400E1CD")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnColorPanel;

		// Token: 0x0400E1CE RID: 57806
		[Token(Token = "0x400E1CE")]
		[FieldOffset(Offset = "0x38")]
		public UISprite SpriteBtnColor;

		// Token: 0x0400E1CF RID: 57807
		[Token(Token = "0x400E1CF")]
		[FieldOffset(Offset = "0x40")]
		public UIPanel PanelShowColor;

		// Token: 0x0400E1D0 RID: 57808
		[Token(Token = "0x400E1D0")]
		[FieldOffset(Offset = "0x48")]
		public UISprite SpritePanelColorBg;

		// Token: 0x0400E1D1 RID: 57809
		[Token(Token = "0x400E1D1")]
		[FieldOffset(Offset = "0x50")]
		public UIGrid GridColorPanel;

		// Token: 0x0400E1D2 RID: 57810
		[Token(Token = "0x400E1D2")]
		[FieldOffset(Offset = "0x58")]
		public Transform InventoryPanelContainer;

		// Token: 0x0400E1D3 RID: 57811
		[Token(Token = "0x400E1D3")]
		[FieldOffset(Offset = "0x60")]
		public GameObject InvertoryToggles;

		// Token: 0x0400E1D4 RID: 57812
		[Token(Token = "0x400E1D4")]
		[FieldOffset(Offset = "0x68")]
		public UIGrid MainToggleGrid;

		// Token: 0x0400E1D5 RID: 57813
		[Token(Token = "0x400E1D5")]
		[FieldOffset(Offset = "0x70")]
		public UIToggleButton ClothToggle;

		// Token: 0x0400E1D6 RID: 57814
		[Token(Token = "0x400E1D6")]
		[FieldOffset(Offset = "0x78")]
		public UIToggleButton LoadoutToggle;

		// Token: 0x0400E1D7 RID: 57815
		[Token(Token = "0x400E1D7")]
		[FieldOffset(Offset = "0x80")]
		public UIToggleButton TreasureBoxToggle;

		// Token: 0x0400E1D8 RID: 57816
		[Token(Token = "0x400E1D8")]
		[FieldOffset(Offset = "0x88")]
		public UIToggleButton BundleToggle;

		// Token: 0x0400E1D9 RID: 57817
		[Token(Token = "0x400E1D9")]
		[FieldOffset(Offset = "0x90")]
		public UIToggleButton GrowthCardToggle;

		// Token: 0x0400E1DA RID: 57818
		[Token(Token = "0x400E1DA")]
		[FieldOffset(Offset = "0x98")]
		public UIToggleButton ExchangeCurrencyToggle;

		// Token: 0x0400E1DB RID: 57819
		[Token(Token = "0x400E1DB")]
		[FieldOffset(Offset = "0xA0")]
		public UIToggleButton EpicClothesToggle;

		// Token: 0x0400E1DC RID: 57820
		[Token(Token = "0x400E1DC")]
		[FieldOffset(Offset = "0xA8")]
		public UIToggleButton InstallmentToggle;

		// Token: 0x0400E1DD RID: 57821
		[Token(Token = "0x400E1DD")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject SubToggles;

		// Token: 0x0400E1DE RID: 57822
		[Token(Token = "0x400E1DE")]
		[FieldOffset(Offset = "0xB8")]
		public UIToggleButton subToggle;

		// Token: 0x0400E1DF RID: 57823
		[Token(Token = "0x400E1DF")]
		[FieldOffset(Offset = "0xC0")]
		public UIGrid SubToggleGrid;

		// Token: 0x0400E1E0 RID: 57824
		[Token(Token = "0x400E1E0")]
		[FieldOffset(Offset = "0xC8")]
		public UIToggleButtonGroup SubToggleGroup;

		// Token: 0x0400E1E1 RID: 57825
		[Token(Token = "0x400E1E1")]
		[FieldOffset(Offset = "0xD0")]
		public UIScrollView InventoryScrollView;

		// Token: 0x0400E1E2 RID: 57826
		[Token(Token = "0x400E1E2")]
		[FieldOffset(Offset = "0xD8")]
		public UIEasyList Grid;

		// Token: 0x0400E1E3 RID: 57827
		[Token(Token = "0x400E1E3")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject NoItemTips;

		// Token: 0x0400E1E4 RID: 57828
		[Token(Token = "0x400E1E4")]
		[FieldOffset(Offset = "0xE8")]
		public UIButton btnOpen;

		// Token: 0x0400E1E5 RID: 57829
		[Token(Token = "0x400E1E5")]
		[FieldOffset(Offset = "0xF0")]
		public UIButton btnExchange;

		// Token: 0x0400E1E6 RID: 57830
		[Token(Token = "0x400E1E6")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel btnExchangelabel;

		// Token: 0x0400E1E7 RID: 57831
		[Token(Token = "0x400E1E7")]
		[FieldOffset(Offset = "0x100")]
		public UIButton btnRename;

		// Token: 0x0400E1E8 RID: 57832
		[Token(Token = "0x400E1E8")]
		[FieldOffset(Offset = "0x108")]
		public UICountDownLabel ExpireTimeLabel;

		// Token: 0x0400E1E9 RID: 57833
		[Token(Token = "0x400E1E9")]
		[FieldOffset(Offset = "0x110")]
		public UIButton btnForge;

		// Token: 0x0400E1EA RID: 57834
		[Token(Token = "0x400E1EA")]
		[FieldOffset(Offset = "0x118")]
		public UIButton btnUpgradeCard;

		// Token: 0x0400E1EB RID: 57835
		[Token(Token = "0x400E1EB")]
		[FieldOffset(Offset = "0x120")]
		public UIButton btnExchangeDebris;

		// Token: 0x0400E1EC RID: 57836
		[Token(Token = "0x400E1EC")]
		[FieldOffset(Offset = "0x128")]
		public UIButton ClothSetRecommend;

		// Token: 0x0400E1ED RID: 57837
		[Token(Token = "0x400E1ED")]
		[FieldOffset(Offset = "0x130")]
		public UIWidget ClothSetRecommendBG;

		// Token: 0x0400E1EE RID: 57838
		[Token(Token = "0x400E1EE")]
		[FieldOffset(Offset = "0x138")]
		public Transform ClothSetRecommendAttachPoint;

		// Token: 0x0400E1EF RID: 57839
		[Token(Token = "0x400E1EF")]
		[FieldOffset(Offset = "0x140")]
		public UIButton btnRepay;

		// Token: 0x0400E1F0 RID: 57840
		[Token(Token = "0x400E1F0")]
		[FieldOffset(Offset = "0x148")]
		public GameObject BackpackSwitchWidget;

		// Token: 0x0400E1F1 RID: 57841
		[Token(Token = "0x400E1F1")]
		[FieldOffset(Offset = "0x150")]
		public UIToggle BackpackSwitchToggle;

		// Token: 0x0400E1F2 RID: 57842
		[Token(Token = "0x400E1F2")]
		[FieldOffset(Offset = "0x158")]
		public UIButton BtnLegendCloth;

		// Token: 0x0400E1F3 RID: 57843
		[Token(Token = "0x400E1F3")]
		[FieldOffset(Offset = "0x160")]
		public UISprite SpriteBtnLegendCloth;

		// Token: 0x0400E1F4 RID: 57844
		[Token(Token = "0x400E1F4")]
		[FieldOffset(Offset = "0x168")]
		public GameObject ClothPreviewTab;

		// Token: 0x0400E1F5 RID: 57845
		[Token(Token = "0x400E1F5")]
		[FieldOffset(Offset = "0x170")]
		public UIToggleButton previewHair;

		// Token: 0x0400E1F6 RID: 57846
		[Token(Token = "0x400E1F6")]
		[FieldOffset(Offset = "0x178")]
		public UIToggleButton previewFace;

		// Token: 0x0400E1F7 RID: 57847
		[Token(Token = "0x400E1F7")]
		[FieldOffset(Offset = "0x180")]
		public UIToggleButton previewHeadAdditive;

		// Token: 0x0400E1F8 RID: 57848
		[Token(Token = "0x400E1F8")]
		[FieldOffset(Offset = "0x188")]
		public UIToggleButton previewChest;

		// Token: 0x0400E1F9 RID: 57849
		[Token(Token = "0x400E1F9")]
		[FieldOffset(Offset = "0x190")]
		public UIToggleButton previewlegs;

		// Token: 0x0400E1FA RID: 57850
		[Token(Token = "0x400E1FA")]
		[FieldOffset(Offset = "0x198")]
		public UIToggleButton previewFeet;

		// Token: 0x0400E1FB RID: 57851
		[Token(Token = "0x400E1FB")]
		[FieldOffset(Offset = "0x1A0")]
		public UIToggleButton previewClothesSet;

		// Token: 0x0400E1FC RID: 57852
		[Token(Token = "0x400E1FC")]
		[FieldOffset(Offset = "0x1A8")]
		public GameObject ItemDesc;

		// Token: 0x0400E1FD RID: 57853
		[Token(Token = "0x400E1FD")]
		[FieldOffset(Offset = "0x1B0")]
		public GameObject itemsdesc;

		// Token: 0x0400E1FE RID: 57854
		[Token(Token = "0x400E1FE")]
		[FieldOffset(Offset = "0x1B8")]
		public UILabel itemDescLabel;

		// Token: 0x0400E1FF RID: 57855
		[Token(Token = "0x400E1FF")]
		[FieldOffset(Offset = "0x1C0")]
		public GameObject itemsname;

		// Token: 0x0400E200 RID: 57856
		[Token(Token = "0x400E200")]
		[FieldOffset(Offset = "0x1C8")]
		public UISprite CalBg;

		// Token: 0x0400E201 RID: 57857
		[Token(Token = "0x400E201")]
		[FieldOffset(Offset = "0x1D0")]
		public UILabel itemNameLabel;

		// Token: 0x0400E202 RID: 57858
		[Token(Token = "0x400E202")]
		[FieldOffset(Offset = "0x1D8")]
		public UISprite CalBg1;

		// Token: 0x0400E203 RID: 57859
		[Token(Token = "0x400E203")]
		[FieldOffset(Offset = "0x1E0")]
		public UIButton GotoAvatarProfileBtn;

		// Token: 0x0400E204 RID: 57860
		[Token(Token = "0x400E204")]
		[FieldOffset(Offset = "0x1E8")]
		public GameObject EpicClothesContainer;

		// Token: 0x0400E205 RID: 57861
		[Token(Token = "0x400E205")]
		[FieldOffset(Offset = "0x1F0")]
		public UIButton EpicClothesUpBtn;

		// Token: 0x0400E206 RID: 57862
		[Token(Token = "0x400E206")]
		[FieldOffset(Offset = "0x1F8")]
		public UILabel EpicClothesUpLabel;

		// Token: 0x0400E207 RID: 57863
		[Token(Token = "0x400E207")]
		[FieldOffset(Offset = "0x200")]
		public UIButton EpicClothesEquipBtn;

		// Token: 0x0400E208 RID: 57864
		[Token(Token = "0x400E208")]
		[FieldOffset(Offset = "0x208")]
		public UILabel EpicClothesEquipBtnLabel;

		// Token: 0x0400E209 RID: 57865
		[Token(Token = "0x400E209")]
		[FieldOffset(Offset = "0x210")]
		public UILabel EpicClothesName;

		// Token: 0x0400E20A RID: 57866
		[Token(Token = "0x400E20A")]
		[FieldOffset(Offset = "0x218")]
		public UIToggleButton EpicClothesSubToggleFirst;

		// Token: 0x0400E20B RID: 57867
		[Token(Token = "0x400E20B")]
		[FieldOffset(Offset = "0x220")]
		public UIToggleButton EpicClothesSubToggle;

		// Token: 0x0400E20C RID: 57868
		[Token(Token = "0x400E20C")]
		[FieldOffset(Offset = "0x228")]
		public UIGrid EpicClothesSubPanelGrid;

		// Token: 0x0400E20D RID: 57869
		[Token(Token = "0x400E20D")]
		[FieldOffset(Offset = "0x230")]
		public UIToggleButtonGroup EpicClothesSubToggleGroup;

		// Token: 0x0400E20E RID: 57870
		[Token(Token = "0x400E20E")]
		[FieldOffset(Offset = "0x238")]
		public UIScrollView EpicClothesScrollPanel;

		// Token: 0x0400E20F RID: 57871
		[Token(Token = "0x400E20F")]
		[FieldOffset(Offset = "0x240")]
		public UIGrid EpicClothesConditionGrid;

		// Token: 0x0400E210 RID: 57872
		[Token(Token = "0x400E210")]
		[FieldOffset(Offset = "0x248")]
		public UIWidget EpicClothesCondition_1_widget;

		// Token: 0x0400E211 RID: 57873
		[Token(Token = "0x400E211")]
		[FieldOffset(Offset = "0x250")]
		public UILabel EpicClothesCondition_1_label;

		// Token: 0x0400E212 RID: 57874
		[Token(Token = "0x400E212")]
		[FieldOffset(Offset = "0x258")]
		public UIWidget EpicClothesCondition_2_widget;

		// Token: 0x0400E213 RID: 57875
		[Token(Token = "0x400E213")]
		[FieldOffset(Offset = "0x260")]
		public UILabel EpicClothesCondition_2_label;

		// Token: 0x0400E214 RID: 57876
		[Token(Token = "0x400E214")]
		[FieldOffset(Offset = "0x268")]
		public UIWidget EpicClothesCondition_3_widget;

		// Token: 0x0400E215 RID: 57877
		[Token(Token = "0x400E215")]
		[FieldOffset(Offset = "0x270")]
		public UILabel EpicClothesCondition_3_label;

		// Token: 0x0400E216 RID: 57878
		[Token(Token = "0x400E216")]
		[FieldOffset(Offset = "0x278")]
		public UISprite EpicClothesChickenSprite;

		// Token: 0x0400E217 RID: 57879
		[Token(Token = "0x400E217")]
		[FieldOffset(Offset = "0x280")]
		public UIButton EpicClothesWaitingRoomEffectBtn;

		// Token: 0x0400E218 RID: 57880
		[Token(Token = "0x400E218")]
		[FieldOffset(Offset = "0x288")]
		public UIButton EpicClothesKillEffectBtn;

		// Token: 0x0400E219 RID: 57881
		[Token(Token = "0x400E219")]
		[FieldOffset(Offset = "0x290")]
		public UIButton EpicClothesFlagBtn;

		// Token: 0x0400E21A RID: 57882
		[Token(Token = "0x400E21A")]
		[FieldOffset(Offset = "0x298")]
		public UILabel EpicClothesFlagBtnLabel;

		// Token: 0x0400E21B RID: 57883
		[Token(Token = "0x400E21B")]
		[FieldOffset(Offset = "0x2A0")]
		public UIButton EpicClothesLootboxBtn;

		// Token: 0x0400E21C RID: 57884
		[Token(Token = "0x400E21C")]
		[FieldOffset(Offset = "0x2A8")]
		public UILabel EpicClothesLootboxLabel;

		// Token: 0x0400E21D RID: 57885
		[Token(Token = "0x400E21D")]
		[FieldOffset(Offset = "0x2B0")]
		public GameObject EpicClothesActionEffectContainer;

		// Token: 0x0400E21E RID: 57886
		[Token(Token = "0x400E21E")]
		[FieldOffset(Offset = "0x2B8")]
		public UIButton EpicClothesActionEffectBtn;

		// Token: 0x0400E21F RID: 57887
		[Token(Token = "0x400E21F")]
		[FieldOffset(Offset = "0x2C0")]
		public UIButton EpicClothesScrollDown;

		// Token: 0x0400E220 RID: 57888
		[Token(Token = "0x400E220")]
		[FieldOffset(Offset = "0x2C8")]
		public UIWidget PreviewLeftContainer;

		// Token: 0x0400E221 RID: 57889
		[Token(Token = "0x400E221")]
		[FieldOffset(Offset = "0x2D0")]
		public UIWidget PreviewRightContainer;
	}
}
